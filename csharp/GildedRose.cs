using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items; // Declares the collection of Item objects.
        public GildedRose(IList<Item> Items) // Constructor for when object is created it gets a collection of items.
        {
            this.Items = Items; //


        }


        // This code is not wrong the issue here is conditions are nested within other conditions
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++) // loops through every item in the collection, each item is checked indvidually.
            {
                Item item = Items[i]; // gets the item at index i in the collection and assigns it to the variable item.

                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    DecreaseQuality(item); // This method manages the conditions internally. 
                    // Extract Method refactoring technique is used here to make the code more readable and maintainable.

                    // Checks if the quality of the item is greater than 0, if it is then it will decrease the quality of the item by 1.

                 

                    {

           

                        
                        {
                            
                        }
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        IncreaseQuality(item); // This method manages the conditions internally.

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11)
                            
                                
                                {
                                    IncreaseQuality(item);
                                }
                            

                            // When the sellIn = 5 both conditions are true and the quality increases by 3.
                            if (item.SellIn < 6)
                            
                                
                                {
                                    IncreaseQuality(item);
                                }

                                
                            
                        }
                    }
                }

                DecreaseSellIn(item);

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            //if (item.Quality > 0)

                            DecreaseQuality(item);
                            {
                                
                                {
                                    
                                }
                            }
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    
                        
                        {
                            IncreaseQuality(item);
                        }



                    
                }
            }
        }

        // This method decreases the quality of an item by 1, but only if the item's quality is greater than 0 and the item is not "Sulfuras, Hand of Ragnaros".
        private void DecreaseQuality(Item item)
        {
            if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality = item.Quality - 1;
            }
        }

        // Helper method, high cohesion, low coupling. This method increases the quality of an item by 1, but only if the item's quality is less than 50.
        private void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }

        private void DecreaseSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
               }
        }


    }
}
    
