using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public int animalsInShelter;

        /// <summary>
        /// Animal Shelter constructor
        /// </summary>
        /// <param name="animal">animal entering the shelter</param>
        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
            animalsInShelter++;
        }

        /// <summary>
        /// adds an animal to the shelter queue
        /// </summary>
        /// <param name="animal">animal entering the shelter</param>
        public void Enqueue(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
            animalsInShelter++;
        }

        /// <summary>
        /// removes animal from shelter queue
        /// </summary>
        /// <returns>removed animal</returns>
        public Animal Dequeue()
        {
            Animal temp = Front;//grabs the animal at the front of the queue
            Front = Front.Next; //sets new front
            temp.Next = null;
            animalsInShelter--;

            return temp;
        }


    }
}
