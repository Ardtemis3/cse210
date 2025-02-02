class PromptManager{
    public List<string> _prompts = new List<string>();
    Random random = new Random();
    public void FillList(){
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("");
        _prompts.Add("");
    }

    public string RandomPrompt(){
        int promptIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[promptIndex];
        return randomPrompt;
    }
}