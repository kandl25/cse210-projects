public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "What are you goals for the upcoming month?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "If you had one thing you could do over today, what would it be?",
        "What is something you want your future generation to know about today?"
    };

    public Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}