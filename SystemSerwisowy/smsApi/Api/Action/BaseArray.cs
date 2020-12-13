using System.Collections.Generic;

namespace smsApi.Api.Action
{
    public abstract class BaseArray<T> : Base<List<T>, smsApi.Api.Response.Array<T>>
    {
        protected override smsApi.Api.Response.Array<T> ConvertResponse(List<T> response)
        {
            return new smsApi.Api.Response.Array<T>(response);
        }
    }
}
