using System.Collections.Generic;

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
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0) // Checks if the quality of the item is greater than 0, if it is then it will decrease the quality of the item by 1.
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros") // checks if the item is not "Sulfuras, Hand of Ragnaros" if it is not then it will decrease the quality of the item by 1.
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            // When the sellIn = 5 both conditions are true and the quality increases by 3.
                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }


                        
                    }
                }
            }
        }
    }
}
