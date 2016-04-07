class Animal {
    // Simple properties
    public int legs { get; set; }
    public int Eyes { get; set; }
    // Public method that can be redefined by derived classes
}

class Genus : Animal {
    public string GenusName { get; set; }
}

// Derived class
class Lizard : Genus {
    // Adding additional properties to what is inherited from Animal
    public string Noise { get; set; }
    public string scaleColor { get; set; }
    public bool camouflage { get; set; }
    public int Stripes { get; set; }
}

class Salamander : Lizard {
    public bool Slimy { get; set; }
    public int Speed { get; set; }
}

class Iguana : Lizard {
    public string Color { get; set; }
    public string EyeShape { get; set; }
}

class BeardedDragon : Lizard {
    public int Size { get; set ;}
    public bool Poison { get; set; }
}

class Monitor : Lizard {

}

class KomodoDragon : Lizard {

}

class Dog : Genus {
    public string Noise { get; set; }
    public int Spots { get; set; }
    public bool Big { get; set; }
    public string Breed { get; set; }
}

class Rottweiler : Dog {
    private int Aggressiveness = 0;
}

class Labrador : Dog {
    public string Color { get; set; }
}

class Poodle : Dog {
    public string Size { get; set; }
}

class Wolf: Dog {
    public bool Howls { get; set; }
}

class Bear : Dog {
    public string Location { get; set; }
}

class Bird : Genus {
    public string Noise { get; set; }
    public string Type { get; set; }
    public bool CanFly { get; set; }
    public int FlightDistance { get; set; }
}

class SunConure : Bird {
    public bool Screams { get; set; }
    public string Foods { get; set; }
    public SunConure (string Fruit) {
        Foods = Fruit;
    }
}

class Pigeon : Bird {
    public string Location { get; set; }
}

class Macaw : Bird {
    public string Size { get; set;}
}

class AfricanGrey : Bird {
    public string Color { get; set; }
}

class Penguin : Bird {
    public bool Gender { get; set; }
    private string _food = "Fish"; 
}