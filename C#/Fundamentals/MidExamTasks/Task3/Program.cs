double experienceRequired = double.Parse(Console.ReadLine());
int battleCounts = int.Parse(Console.ReadLine());
double neededExperience = 0;
double expEarned = 0;
int counter = 0;
for(int i = 1; i <= battleCounts; i++){

     counter++;

    expEarned = double.Parse(Console.ReadLine());
    neededExperience += expEarned;

    if (i% 3 == 0){
     
     neededExperience += expEarned * 0.15;

    }
    if (i % 5 == 0){

        neededExperience -= expEarned * 0.10;
    }
    if (i % 15 == 0){

        neededExperience += expEarned * 0.05;
    }
    
    
    if (neededExperience >= experienceRequired){

        break;
    }
    
}

if (neededExperience >= experienceRequired){

        Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
        
    }

else {

        Console.WriteLine($"Player was not able to collect the needed experience, {experienceRequired-neededExperience:f2} more needed.");
    }