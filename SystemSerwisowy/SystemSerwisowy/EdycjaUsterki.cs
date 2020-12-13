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
    public partial class EdycjaUsterki : Form
    {
        SekcjaSerwisu serwis;
        Usterka temp;
        int indeks;
        public EdycjaUsterki(SekcjaSerwisu s, int ind)
        {
            indeks = ind;
            serwis = s;
            InitializeComponent();
            temp = serwis.glowna.listaUsterek[ind];
            UzupelnijFormularz(temp);
        }

        private void UzupelnijFormularz(Usterka usterka)
        {
            tbId.Text = usterka.ID.ToString();
            tbDataOd.Text = usterka.DataZgloszenia;
            tbKoszt.Text = usterka.Koszt;
            tbModel.Text = usterka.Model;
            tbNazwisko.Text = usterka.Nazwisko;
            tbNumer.Text = usterka.NumerSeryjny;
            tbOpis.Text = usterka.Opis;
            tbTelefon.Text = usterka.Telefon;
            tbUwagi.Text = usterka.Uwagi;
            tbDataDo.Text = usterka.DataRealizacji;
            tbNaprawy.Text = usterka.WykonaneNaprawy;
            if (usterka.Uwagi.Contains("Pilne"))
            {
                chbPilne.Checked = true;
            }
            else
            {
                chbPilne.Checked = false;
            }
            switch (usterka.Odbior)
            {
                case "TAK":
                    cbOdbior.SelectedIndex = 1;
                    break;
                default:
                    cbOdbior.SelectedIndex = 0;
                    break;
            }
            try
            {
                cbStatus.SelectedItem = usterka.Status;
            }
            catch
            {
                cbStatus.SelectedIndex = 0;
            }
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            serwis.Enabled = true;
            serwis.AktualizujGrida();
            serwis.Focus();
        }

        private void btZapisz_Click(object sender, EventArgs e)
        {
            zapiszZmiany();
            Close();
        }

        private void zapiszZmiany()
        {
            DateTime a;
            serwis.glowna.listaUsterek[indeks].ID = Convert.ToInt32(tbId.Text);
            if (DateTime.TryParse(tbDataOd.Text, out a))
            {
                serwis.glowna.listaUsterek[indeks].DataZgloszenia = tbDataOd.Text;
            }
            if (DateTime.TryParse(tbDataDo.Text, out a))
            {
                serwis.glowna.listaUsterek[indeks].DataRealizacji = tbDataDo.Text;
            }
            serwis.glowna.listaUsterek[indeks].Koszt = tbKoszt.Text;
            serwis.glowna.listaUsterek[indeks].Model = tbModel.Text;
            serwis.glowna.listaUsterek[indeks].Nazwisko = tbNazwisko.Text;
            serwis.glowna.listaUsterek[indeks].NumerSeryjny = tbNumer.Text;
            serwis.glowna.listaUsterek[indeks].Opis = tbOpis.Text;
            serwis.glowna.listaUsterek[indeks].Status = cbStatus.SelectedItem.ToString();
            serwis.glowna.listaUsterek[indeks].Telefon = tbTelefon.Text;
            serwis.glowna.listaUsterek[indeks].Uwagi = tbUwagi.Text;
            serwis.glowna.listaUsterek[indeks].Odbior = cbOdbior.SelectedItem.ToString();
            if (cbOdbior.SelectedItem.ToString() == "TAK" && serwis.glowna.listaUsterek[indeks].DataOdbioru == "")
            {
                serwis.glowna.listaUsterek[indeks].DataOdbioru = DateTime.Now.ToString("yyyy-MM-dd");
            }
            serwis.glowna.listaUsterek[indeks].WykonaneNaprawy = tbNaprawy.Text;
            if (chbPilne.Checked && !serwis.glowna.listaUsterek[indeks].Uwagi.Contains("Pilne"))
            {
                serwis.glowna.listaUsterek[indeks].Uwagi += "Pilne";
            }
            serwis.glowna.nadpiszUsterki();
            serwis.Enabled = true;
            serwis.AktualizujGrida();
            serwis.Focus();
        }

        private void EdycjaUsterki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pomocnik pomoc = new Pomocnik();
            Usterka uster = new Usterka(Convert.ToInt32(tbId.Text),tbTelefon.Text, tbNazwisko.Text, tbModel.Text, tbNumer.Text,tbDataOd.Text,  tbDataDo.Text, tbOpis.Text, (chbPilne.Checked)? tbUwagi.Text + "Pilne": tbUwagi.Text, tbKoszt.Text, 
                cbStatus.SelectedItem.ToString(),cbOdbior.SelectedItem.ToString(),tbNaprawy.Text ,DateTime.Now.ToShortDateString()  );
            if (pomoc.czyUsterkiTakieSame(serwis.glowna.listaUsterek[indeks], uster))
            {
                serwis.Enabled = true;
                serwis.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wykonałeś pewne zmiany. Czy chcesz je zapisać?", "Zapisać zmiany?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    zapiszZmiany();
                }
                else if (dialogResult == DialogResult.No)
                {
                    serwis.Enabled = true;
                    serwis.Focus();
                }
            }

        }
        protected smsApi.Api.IClient _client;
        protected smsApi.Api.ProxyAddress _proxyAddress;
        protected string _validTestNumber;
        protected string _username;
        protected string _password;
        private void btnWyslijSms_Click(object sender, EventArgs e)
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


                var smsapi = new smsApi.Api.SMSFactory(_client, smsApi.Api.ProxyAddress.SmsApiPl);

                var result =
                    smsapi.ActionSend()
                        .SetText("Hej Lukasz testuje smsAPI :)")
                        .SetTo("504402500")
                        .SetSender("Lumik") //Sender name
                        .Execute();

                MessageBox.Show("Send: " + result.Count);
                System.Console.WriteLine("Send: " + result.Count);

                string[] ids = new string[result.Count];

                for (int i = 0, l = 0; i < result.List.Count; i++)
                {
                    if (!result.List[i].isError())
                    {
                        if (!result.List[i].isFinal())
                        {
                            ids[l] = result.List[i].ID;
                            l++;
                        }
                    }
                }

                System.Console.WriteLine("Get:");
                result =
                    smsapi.ActionGet()
                        .Ids(ids)
                        .Execute();

                foreach (var status in result.List)
                {
                    System.Console.WriteLine("ID: " + status.ID + " NUmber: " + status.Number + " Points:" + status.Points + " Status:" + status.Status + " IDx: " + status.IDx);
                }

                for (int i = 0, l = 0; i < result.List.Count; i++)
                {
                    if (!result.List[i].isError())
                    {
                        var deleted =
                            smsapi.ActionDelete()
                                .Id(result.List[i].ID)
                                .Execute();
                        System.Console.WriteLine("Deleted: " + deleted.Count);
                    }
                }
            }
            catch (smsApi.Api.ActionException r)
            {
                /**
                 * Action error
                 */
                System.Console.WriteLine(r.Message);
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
                System.Console.WriteLine(a.Message);
            }
            catch (smsApi.Api.HostException q)
            {
                /* 
                 * Server errors
                 * SMSApi.Api.HostException.E_JSON_DECODE - problem with parsing data
                 */
                System.Console.WriteLine(q.Message);
            }
            catch (smsApi.Api.ProxyException p)
            {
                // communication problem between client and sever
                System.Console.WriteLine(p.Message);
            }
        }
    }
}
