class Animal {
    // Simple properties
    public double speed { get; set; }
    public string species { get; set; }
    public int legs { get; set; }
    // Public method that can be redefined by derived classes
}

class Species : Animal {
    public string SpeciesName { get; set; }
}



// Derived class
class Lizard : Species {
    // Adding additional properties to what is inherited from Animal
    public string Noise { get; set; }
    public string scaleColor { get; set; }
    public bool camouflage { get; set; }
    public int Stripes { get; set; }
}

class Dog : Species {
    public string Noise { get; set; }
    public int Spots { get; set; }
    public bool Big { get; set; }
    public string Breed { get; set; }
}

class Parrot : Species {
    public string Noise { get; set; }
    public string Type { get; set; }
    public bool CanFly { get; set; }
    public int FlightDistance { get; set; }
}

Dog buddy = new Dog();

buddy.Noise = "loud";
buddy.Spots = 20;
buddy.Big = true;
buddy.Breed = "Labrador Retriever";

Console.Write("I have a Dog named Buddy who makes a noise that sounds {0}. He has {1} spots. His breed is {2}.", buddy.Noise, buddy.Spots, buddy.Breed);

Parrot peaches = new Parrot();

peaches.Noise = "loud";
peaches.Type = "Sun Conure";
peaches.CanFly = true;
peaches.FlightDistance = 25;

Console.Write("I have a Parrot named Peaches who makes a noise that sounds {0}. It is {1} that he can fly. He is a {2}.", peaches.Noise, peaches.CanFly, peaches.Type);

Lizard sam = new Lizard();

sam.Noise = "quiet";
sam.scaleColor = "Green";
sam.camouflage = false;
sam.Stripes = 4;

Console.Write("I have a Lizzard named Sam who makes a noise that sounds {0}. It is {1} . It is {2} that he can camouflage.", sam.Noise, sam.scaleColor, sam.camouflage);