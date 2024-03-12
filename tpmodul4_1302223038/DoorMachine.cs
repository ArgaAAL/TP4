using System;

class DoorMachine
{
    private string state = "Terkunci";

    public void ChangeState(string newState)
    {
        if (newState == "Terkunci")
        {
            Console.WriteLine("Pintu terkunci");
        }
        else if (newState == "Terbuka")
        {
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Perintah tidak valid");
            return;
        }
        state = newState;
    }
}
