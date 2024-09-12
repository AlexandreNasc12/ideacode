namespace ideacode.core.Communication
{
    public class ResponseResult
    {
        public ResponseResult(object data = null)
        {
            this.data = data;
            errors = new List<string>();
        }

        public ResponseResult() { }

        public object data { get; set; }
        public bool success { get; set; }
        public List<string> errors { get; set; }
    }
}