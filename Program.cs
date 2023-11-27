class Program {
    static void Main(string[] args){
        Gamemaster gamemaster = new Gamemaster();
        User user = GetUser(gamemaster);
        gamemaster.LoadLobby(user,gamemaster);
    }

    public static User GetUser(Gamemaster gamemaster){
        Console.Clear();
        Console.WriteLine($"• • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • Media Adventure • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • • ");
        Console.WriteLine("✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧");
        gamemaster.PrintNL(" Welcome to Media Adventure ");
        gamemaster.PrintNL(" Create Work by Nhakluamak Group ");
        Console.WriteLine("✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧✧");
        Console.WriteLine("                                                                 〚login〛      〚register〛");

        User returnVal;

        Console.Write("୨⎯ Select menu ⎯୧ | ");
        switch (Console.ReadLine()){
            case "login":
                returnVal = gamemaster.Login(gamemaster);
                break;
            case "register":
                returnVal = gamemaster.Register(gamemaster);
                break;   
            default:
                Console.Clear();
                gamemaster.Print("Error pls try again");
                returnVal = GetUser(gamemaster);
                break;     
        }
        return returnVal;
    }
}