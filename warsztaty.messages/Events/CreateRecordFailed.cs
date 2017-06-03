namespace warsztaty.messages.Events
{
    public class CreateRecordFailed
    {
        public string Key { get; }
        public string Reason { get; }

        public CreateRecordFailed(string key, string reason)
        {
            Key = key;
            Reason = Reason;
        }

        protected CreateRecordFailed()
        {
        }
    }
}
