using ValueAndReferenceTypes;
using Xunit;

namespace ValueAndReferenceTypesTests
{
    public class ValAndRefTypesTests
    {
        [Fact]
        public void RefTypeTest()
        {
            //Kutuphanenin proje basvurusunu bagýmliliklara ekliyoruz.

            //Arrange = duzenleme ifadesi
            var p1 = new RefType()
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            //Act = eylem
            p1.X = 30;

            //Assert  = iddia
            Assert.Equal(p1.X, p2.X);


        }

        [Fact]
        public void ValTypeTest()
        {

            //Arrange 
            var p1 = new ValueType() //Buradaki ValueType sistemden gelmemelidir.
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            //Act
            p1.X = 30;

            //Assert
            Assert.NotEqual(p1.X, p2.X); 


           

        }

        [Fact]
        public void RecordTypeTest()
        {
            //Arrange
            var p1 = new RecordType(3, 5);

            //Act
            var p2 = new RecordType(3, 5);

            /*referanslari farkli diyebiliyoruz
            cunku newleme yaptýk bunlar stackte farkli bir adres isaret etmektedir.*/

            //Assert
            Assert.Equal(p1,p2); //referanslari farkli ama degerleri esit

        }

        [Fact]
        public void SwapByVal()
        {
            //Arrange = duzenleme ifadesi
            int a = 23, b = 55;
            var valType = new ValueType();
            
            //Act = eylem
            valType.Swap(a, b);

            //Assert = iddia
            Assert.Equal(55, b);
            Assert.Equal(23, a); //deger tipli oldugu icin testten gecicegini gorecegiz
            
            //Assert.Equal(23, a); diye yazarsak a ile b nin yer degistirmesini bekleriz
            /*Testin hata verdigini goruruz aslinda
            swap islemi gerceklesiyor ama metodun icerisinde gerceklestigini goruruz
            globale etki etmiyor */

        }

        [Fact]
        public void SwapByRef()
        {
            //Arrange 

            int a = 23, b = 55;
            var valType = new RefType();
            
            //Act 

            valType.Swap(ref a, ref b);

            //Assert
            Assert.Equal(55, a); //a nin gostermis oldugu adresteki deger degisiyor
            Assert.Equal(23, b);

        }

        [Fact]
        public void CheckOutKeyword()
        {
            //Arrange
            var refType = new RefType();
            int b = 50;

            //Act
            refType.CheckOut(out b);

            //Assert
            Assert.Equal(100, b);
        }
    }
}
