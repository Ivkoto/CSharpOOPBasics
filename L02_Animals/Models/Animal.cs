public abstract class Animal
{
    private string name;
    private string favouriteFood;

    public Animal(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public string FavoriteFood
    {
        get { return this.favouriteFood; }
        private set { this.favouriteFood = value; }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my favourite food is {this.FavoriteFood}";
    }
}