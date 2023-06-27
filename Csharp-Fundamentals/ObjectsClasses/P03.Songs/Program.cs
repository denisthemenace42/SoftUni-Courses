﻿int numberOfSongs = int.Parse(Console.ReadLine());
List<Song> songs = new List<Song>();

for (int i = 0; i <numberOfSongs;i++){

    string[] tokens = Console.ReadLine().Split("_").ToArray();

    string typeList = tokens[0];
    string name = tokens[1];
    string time = tokens[2];

    Song song = new Song(typeList,name,time);
    songs.Add(song);

}

string inputOption = Console.ReadLine();

if (inputOption == "all"){
    
    foreach(Song song in songs){

        Console.WriteLine(song.Name);
    }

}
else {
    
    foreach (Song song in songs){

        if (song.TypeList == inputOption){

           Console.WriteLine(song.Name);
        }
    }

}

public class Song
{
    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }

    public string TypeList { get; set;}

    public string Name {get;set;}

    public string Time {get;set;}
}