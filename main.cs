using System;

class Skills
{
   public static void Main(string[] args)
   {
     char element;
     string aspect_input = null;
     string aspect_output = null;
     bool isUnknown = false;
     string Answer = null;
     bool isValidAnswer_bool = false;
     string isValidAnswer = null;
            Console.WriteLine("Hello User, what is your aptitude\n" + 
            "\n1.- Pyro" +
            "\n2.- Geo" +
            "\n3.- Aero" +
            "\n4.- Hydro" +
            "\n5.- Ordo" +
            "\n6.- Perditio\n");
            element = Console.ReadLine()[0];
            switch(element){
              case '1': aspect_input = "Pyro";
              break;
              case '2': aspect_input = "Geo";
              break;
              case '3': aspect_input = "Aero";
              break;
              case '4': aspect_input = "Hydro";
              break;
              case '5': aspect_input = "Ordo";
              break;
              case '6': aspect_input = "Perditio";
              break;
              default: aspect_input = "Unknown";
              break;
            };
        switch(aspect_input){
          case "Pyro": aspect_output = "fire";
          break;
          case "Geo": aspect_output = "earth";
          break;
          case "Aero": aspect_output = "air";
          break;
          case "Hydro": aspect_output = "water";
          break;
          case "Ordo": aspect_output = "order";
          break;
          case "Perditio": aspect_output = "entropy";
          break;
          default: isUnknown = true; 
          break;
        }
        if(isUnknown != true){
        Console.WriteLine("Oh, well you are a " + aspect_output + " user..." + "\nDo you have another aptitude?");
        } else {
        Console.WriteLine("Hmm, that is not available in here, Sorry!");
        };
        Answer = Console.ReadLine();
  isValidAnswer_bool = Convert.ToBoolean(Answer);

  if(isValidAnswer_bool == true){
    isValidAnswer = "Yes";
  } else {
    isValidAnswer = "No";
  };
        switch(isValidAnswer){
          case "Yes": Console.WriteLine("So..., What is it?"); Finished = true;
          break;
          case "No": Console.WriteLine("Hmm, okay so you are an " + aspect_output + " user"); Finished = false;
          break;
          case "yes": Console.WriteLine("So..., What is it?"); Finished = true;
          break;
          case "no": Console.WriteLine("Hmm, okay so you are an " + aspect_output + " user"); Finished = false;
          break;
          default: Console.WriteLine("Invalid answer, try again"); Finished = false;
          break;
      };
  }
}