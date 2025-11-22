
dog animal = new dog();
animal.bark();
animal.speak();


animal animal1 = new animal();







class dog : animal
{
    public string breed;
    public void bark()
        {
        System.Console.WriteLine("Woof! Woof!");//hello 
    }
    public string dogbreed { get; set; } //work

}






class animal
    {
    public string name;
    public int age;
    public void speak()
        {
        System.Console.WriteLine("The animal makes a sound.");
    }//why
    public void feed()
        {
        System.Console.WriteLine("The animal is being fed.");
    }
}