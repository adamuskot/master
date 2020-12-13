using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using smsApi;
namespace SystemSerwisowy
{
    public partial class WyslijSMS : Form
    {
        protected smsApi.Api.IClient _client;
        protected smsApi.Api.ProxyAddress _proxyAddress;
        protected string _validTestNumber;
        protected string _username;
        protected string _password;
        public EdycjaUsterki sekcjaEdycjiUsterki;
        public Usterka usterka;
        public WyslijSMS(EdycjaUsterki e, Usterka u)
        {
            sekcjaEdycjiUsterki = e;
            usterka = u;
            InitializeComponent();
            UzupelnijFormatke();
        }

        private void UzupelnijFormatke()
        {
            tbNazwaNadawcy.Text = sekcjaEdycjiUsterki.serwis.glowna.nadawcaSms;
            tbNumerOdbiorcy.Text = usterka.Telefon;
            rtbTrescSMS.Clear();
            rtbTrescSMS.AppendText(sekcjaEdycjiUsterki.serwis.glowna.trescSms);
        }

        private void btWyslij_Click(object sender, EventArgs e)
        {
            try
            {
                //smsApi.Api.IClient client = new smsApi.Api.ClientOAuth("token");
                var authorizationType = ConfigurationManager.AppSettings["authorizationType"];

                if (authorizationType == smsApi.Api.AuthorizationType.basic.ToString())
                {
                    var basicClient = new smsApi.Api.Client(_username);
                    basicClient.SetPasswordHash(ConfigurationManager.AppSettings["password"]);
                    _client = basicClient;
                }
                else if (authorizationType == smsApi.Api.AuthorizationType.oauth.ToString())
                {
                    _client = new smsApi.Api.ClientOAuth(ConfigurationManager.AppSettings["oauthToken"]);
                }
                string trescSms = "";
                foreach (string item in rtbTrescSMS.Lines)
                {
                    trescSms += item;
                }

                var smsapi = new smsApi.Api.SMSFactory(_client, smsApi.Api.ProxyAddress.SmsApiPl);

                var result =
                    smsapi.ActionSend()
                        .SetText(trescSms)
                        .SetTo(tbNumerOdbiorcy.Text)
                        .SetSender(tbNazwaNadawcy.Text) //Sender name
                        .Execute();

                MessageBox.Show("Wiadomość wysłana pomyślnie.");
                Usterka u = sekcjaEdycjiUsterki.serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.ID == usterka.ID).FirstOrDefault();
                u.SMS = "TAK";
                sekcjaEdycjiUsterki.UzupelnijFormularz(u);
                sekcjaEdycjiUsterki.serwis.glowna.nadpiszUsterki();
                sekcjaEdycjiUsterki.Enabled = true;
                sekcjaEdycjiUsterki.Focus();

                //System.Console.WriteLine("Send: " + result.Count);

                //string[] ids = new string[result.Count];

                //for (int i = 0, l = 0; i < result.List.Count; i++)
                //{
                //    if (!result.List[i].isError())
                //    {
                //        if (!result.List[i].isFinal())
                //        {
                //            ids[l] = result.List[i].ID;
                //            l++;
                //        }
                //    }
                //}

                //System.Console.WriteLine("Get:");
                //result =
                //    smsapi.ActionGet()
                //        .Ids(ids)
                //        .Execute();

                //foreach (var status in result.List)
                //{
                //    System.Console.WriteLine("ID: " + status.ID + " NUmber: " + status.Number + " Points:" + status.Points + " Status:" + status.Status + " IDx: " + status.IDx);
                //}

            }
            catch (smsApi.Api.ActionException r)
            {
                /**
                 * Action error
                 */

                MessageBox.Show("Nie udało sięwysłać wiadomości SMS. " + r.Message);
            }
            catch (smsApi.Api.ClientException a)
            {
                /**
                 * Error codes (list available in smsapi docs). Example:
                 * 101 	Invalid authorization info
                 * 102 	Invalid username or password
                 * 103 	Insufficient credits on Your account
                 * 104 	No such template
                 * 105 	Wrong IP address (for IP filter turned on)
                 * 110	Action not allowed for your account
                 */

                MessageBox.Show("Nie udało sięwysłać wiadomości SMS. " + a.Message);
            }
            catch (smsApi.Api.HostException q)
            {
                /* 
                 * Server errors
                 * SMSApi.Api.HostException.E_JSON_DECODE - problem with parsing data
                 */

                MessageBox.Show("Nie udało sięwysłać wiadomości SMS. " + q.Message);
            }
            catch (smsApi.Api.ProxyException p)
            {
                // communication problem between client and sever

                MessageBox.Show("Nie udało sięwysłać wiadomości SMS. " + p.Message);
            }



        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            sekcjaEdycjiUsterki.Enabled = true;
            sekcjaEdycjiUsterki.Focus();
        }

        private void WyslijSMS_FormClosing(object sender, FormClosingEventArgs e)
        {
            sekcjaEdycjiUsterki.Enabled = true;
            sekcjaEdycjiUsterki.Focus();
        }

    }
}
