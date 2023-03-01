namespace FrotaApp.Application.Input.Receivers
{
    public class State
    {
        public State (int statusCode, string message, object data)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }
        public int StatusCode;
        public string Message;
        public object Data { get; set; }
    }
}