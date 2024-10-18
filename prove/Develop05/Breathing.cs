public class Breathing : Activity
{
    public override void Execute()
    {
        ShowStartMessage("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        int time = duration;
        while (time > 0)
        {
            Console.WriteLine("Breath in......");
            Spinner(4); 
            time -= 4;
            
            Console.WriteLine("Breath out...");
            Spinner(4); 
            time -= 4;
        }

        ShowEndMessage("Breathing");
    }
}
