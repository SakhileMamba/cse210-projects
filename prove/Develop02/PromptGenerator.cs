public class PromptGenerator
{
    List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Reflect on a recent accomplishment or success. How did it make you feel? What steps did you take to achieve it?",
        "Describe a challenge or obstacle you encountered today. How did you handle it? What did you learn from the experience?",
        "Write about a person who has had a significant impact on your life. How have they influenced you? What lessons have you learned from them?",
        "Explore a recent mistake or failure. What went wrong? How did you react, and what did you learn from the situation?",
        "Discuss a goal or aspiration you have for the future. Why is it important to you? What steps can you take to work towards it?",
        "Reflect on a book, movie, or piece of art that has resonated with you recently. What themes or messages stood out to you, and why?",
        "Describe a place that holds special meaning to you. Why is it significant, and what memories or emotions does it evoke?",
        "Describe a skill or hobby you would like to develop further. Why does it interest you, and what steps can you take to improve in that area?",
        "Write about a fear or insecurity you have. What is its origin, and how does it affect you? Can you identify strategies to overcome or manage it?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(0, (_prompts.Count-1))];
    }
}