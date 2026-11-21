using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
{
    "What was the best part of my day?",
    "What did I learn today?",
    "Who did I help today?",
    "What made me happy today?",
    "What could I have done better today?"
};
public string GetRandomPrompt()
{
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
}
}