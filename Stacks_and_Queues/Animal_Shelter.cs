using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues
{
    /*
     * Question : An animal shelter, which holds only dogs and cats, operates on a strictly "first in, first out" basis. People must adopt either the "oldest"
     * (based on arrival time) of all animals at the shelter, or they can select whether they would prefer a dog or cat (and will receive the oldest animal of that
     * type). They cannot select which specific animal they would like. Create the data structures to maintain this system and implement operations such as
     * enqueue, dequeueAny, dequeueDog, and dequeueCat. You can use any built in Data Structure.
     */
    class Animal_Shelter
    {
        Queue<Animal> dogs;
        Queue<Animal> cats;
        int timer;
        public Animal_Shelter()
        {
            dogs = new Queue<Animal>();
            cats = new Queue<Animal>();
            timer = 0;
        }

        public void Enqueue(string animal_name, string animal_type)
        {
            Animal a = new Animal(animal_name, timer);
            if (animal_type == "DOG")
            {
                dogs.Enqueue(a);
            }
            else
            {
                cats.Enqueue(a);
            }
            timer += 1;
        }

        public Animal DequeueAny()
        {
            if (dogs.Peek().Order > cats.Peek().Order)
                return dogs.Dequeue();
            else
                return cats.Dequeue();
        }

        public Animal DequeueDog()
        {
            if (dogs.Count > 0)
                return dogs.Dequeue();

            return null;
        }

        public Animal DequeueCat()
        {
            if (cats.Count > 0)
                return cats.Dequeue();

            return null;
        }
    }

    class Animal
    {
        public Animal(string name, int order)
        {
            Name = name;
            Order = order;
        }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
