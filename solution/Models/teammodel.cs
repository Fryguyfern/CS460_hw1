namespace solution.Models;

public class teammodel{
    private static Random _rand= new Random();
    public static string[] names = [];
    public static List<List<string>> teamsplit=new List<List<string>>(){};
    public static void makenames(string[] newnames){
        names=newnames;
    }
    
    public static void shuffle( int teamsize){
        teamsplit=new List<List<string>>(){};
        _rand.Shuffle(names);
        int count=0;
        List<string> templist=new List<string>(){};
        foreach(string name in names){
            templist.Add(name);
            count++;
            if(count==teamsize){
                teamsplit.Add(templist);
                templist=new List<string>(){};
                count=0;
            }
        }
        if(templist.Count >0){
            teamsplit.Add(templist);
        }
    }
}