using Xunit;
using System.Collections.Generic;

// Automatic fix of indentation using Ctrl + K, Ctrl+D

namespace csharp
{
    public class GildedRoseTest
    {
        [Fact]
        public void NormalItemQualityDecreasesByOne()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(19, Items[0].Quality); // Checking quality of the item after updating quality, expected value is 19.
        }

        [Fact]
        public void NormalItemQualityCannotBeNegative()
        {
            IList<Item> Items = new List<Item>
            {
            new Item { Name = "foo", SellIn = 10, Quality = 0 }
            };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(0, Items[0].Quality); // Checking quality of the item after updating quality, expected value is 0.)

            // if (items[i].Quality > 0) were not present it could decrease to -1



        }

        [Fact]

        public void AgedBrieQualityIncreasesByOne()
        {
            IList<Item> Items = new List<Item>
        {
            new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 }
        };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(21, Items[0].Quality); // Checking quality of the item after updating quality, expected value is 21.
        }

        [Fact]
        public void AgedBrieQualityCannotExceed50()
        {
            IList<Item> Items = new List<Item>
        {
            new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 }
        };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality); // Checking quality of the item after updating quality, expected value is 50.
        }

        [Fact]
        public void SulfurasQualityAndSellInNeverChange()
        {
            IList<Item> Items = new List<Item>
        {
            new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 }
        };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(80, Items[0].Quality); // Checking quality of the item after updating quality, expected value is 80.
            Assert.Equal(10, Items[0].SellIn); // Checking sellin of the item after updating quality, expected value is 10.

            // Two assertions here to check that both quality and sellin remain unchanged for Sulfuras.
        }

        // Backstage passes quality increases by 1 when there are more than 10 days left, by 2 when there are 10 days or less, and by 3 when there are 5 days or less. Quality drops to 0 after the concert.

        [Fact]
        public void BackstagePassQualityIncreasesByOne()
        {
            IList<Item> Items = new List<Item>
        {
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 }
        };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(21, Items[0].Quality); // Checking quality of the item after updating quality, expected value is 21.

            // After update the orginal method checks the items SellIn value before decreasing it.
            // This is important when we test the boundaries at 10 and 5 days.

        }

        [Fact]
        public void BackstagePassQualityIncreasesByTwoAt10Days()
        {
            IList<Item> Items = new List<Item>
        {
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 }
        };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(22, Items[0].Quality);// Checking quality of the item after updating quality, expected value is 22.
            Assert.Equal(9, Items[0].SellIn); // Checking sellin of the item after updating quality, expected value is 9.])
        }


        [Fact]
        public void BackstagePassQualityIncreaseByThreeAt5Days()
        {
            IList<Item> Items = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 }

            };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(23, Items[0].Quality); // Checking quality of the item after updating quality, expected value is 23.)
            Assert.Equal(4, Items[0].SellIn); // Checking sellin of the item after updating quality, expected value is 4.)
        }

        [Fact]
        public void BackstagePassQualityDropsToZeroAfterConcert()
        {
            IList<Item> Items = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality); // Checking quality of the item after updating quality, expected value is 0.)
            Assert.Equal(-1, Items[0].SellIn); // Checking sellin of the item after updating quality, expected value is -1.)

            // Firstly it increases the quality by 3 because the conceret is close
            // Then it checks if the sellin is less than 0 and sets the quality to 0.
        }

        [Fact]
        public void NormalItemQualityDecreasesTwiceAsFastAfterSellDate()
        {
            IList<Item> Items = new List<Item>
            {
                new Item { Name = "foo", SellIn = 0, Quality = 20 }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(18, Items[0].Quality); // Checking quality of the item after updating quality, expected value is 18.)
            Assert.Equal(-1, Items[0].SellIn); // Checking sellin of the item after updating quality, expected value is -1.])

            // Firstly the program understands that SellIn = 0 and Quality = 20 is a normal item and decreases its quality by 1
            // Then it checks if the SellIn is less than 0 and decreases the quality by 1 again.
            // This is why the quality decreases by 2 in total.
        }
    }

    
    }


