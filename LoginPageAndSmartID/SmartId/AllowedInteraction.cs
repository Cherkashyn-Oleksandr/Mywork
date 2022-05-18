namespace LoginPageAndSmartID
{
    public class AllowedInteraction
    {
        public AllowedInteraction(AllowedInteractionType type, string displayText)
        {
            Type = type;
            DisplayText = displayText;
        }

        public AllowedInteractionType Type { get; }

        public string DisplayText { get; }
    }
}