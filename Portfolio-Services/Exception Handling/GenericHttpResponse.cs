using System.Net;

namespace Portfolio_Services.Exception_Handling
{
    public class GenericHttpResponse<T>
    {
        public int? status { get;  set; }
        public string? message { get;  set; }
        public string? reason {  get;  set; }
        public HttpStatusCode? httpStatusCode { get;  set; }
        public T? payload   { get;  set; }
        public DateTime dateTime { get; set; }

        public GenericHttpResponse() { }

        public GenericHttpResponse(int? status, string? message, string? reason, HttpStatusCode? httpStatusCode, T? payload, DateTime dateTime)
        {
            this.status = status;
            this.message = message;
            this.reason = reason;
            this.httpStatusCode = httpStatusCode;
            this.payload = payload;
            this.dateTime = dateTime;
        }

        public override string? ToString()
        {
            return $"Status: {status}, Message: {message}, Reason: {reason}, HttpStatusCode: {httpStatusCode}, Payload: {payload}";
        }
    }
}
