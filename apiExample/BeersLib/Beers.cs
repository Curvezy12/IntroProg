﻿using System;
using System.Collections.Generic;

namespace BeersLib
{
    public class Beer {

        public string Name { get; set; }

        public string Brewery { get; set; }

        // Abv: Alchohol % by volume
        public float Abv { get; set; }

        // Ibu: International bitterness unit
        public int Ibu { get; set; }

        public int Amount { get; set; }

        public float Cost { get; set; }

        public bool Open { get; set;}

        public Beer () {}
        public Beer (string name, string brewery, float abv, int ibu, int amount, float cost) 
        {
            this.Name = name;
            this.Brewery = brewery;
            this.Abv = abv;
            this.Ibu = ibu; 
            this.Amount = amount;
            this.Cost = cost;
            this.Open = false;    
        }

        public int Drink(int amount) {
            throw new NotImplementedException();
        }
        public bool OpenBeer() {
            throw new NotImplementedException();
        }
    }

    public class Beers {

        public List<Beer> BeersList { get; set; }

        public Beers() {
            this.BeersList = new List<Beer>();
            this.BeersList.Add(new Beer("Fosters", "CUB", 4.5f, 12, 350, 6f));
            this.BeersList.Add(new Beer("VB", "CUB", 4.5f, 16, 375, 5f));
            this.BeersList.Add(new Beer("Colonial Pale", "Colonial Brewing", 4.4f, 35, 375, 7f));
            this.BeersList.Add(new Beer("Coopers", "Coopers", 3.5f, 5, 375, 5.5f));
        }
        public Beers(List<Beer> beersList) {
            BeersList = beersList;
        }

        public Beer GetLightestBeer() {
            throw new NotImplementedException();
        }

        public Beer CompareAbv() {
            throw new NotImplementedException();
        }
        //return heaviest beer
        public Beer GetHighestBeer() {
            throw new NotImplementedException();
        }

        public void AddBeer(Beer newBeer) {
            throw new NotImplementedException();
        }

        public void RemoveBeer(Beer removeBeer) {
            throw new NotImplementedException();
        }

        public void UpdateBeer(Beer UpdateBeer) {
            throw new NotImplementedException();
        }
        
        public Beer GetBeerByName(string name) {
            foreach(Beer b in this.BeersList) {
                if(b.Name == name) {
                    return b;
                }
            }

            return null;
        }
    }
}
