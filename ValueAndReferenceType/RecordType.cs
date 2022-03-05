namespace ValueAndReferenceTypes
{
    //Record ifadeleri daha cok verilerin tasinmasi icin kullanilan bir ifadedir.
    //Immutable (DTO) Degismez bir ifade oldugunu biliyoruz.
    //Baslangic asamasinda kullanilirken degeri veriliyor sonra da degeri degismemesi isteniyor.
    //LINQ
    //Value? Bir tipin degerine bagli olarak karsilastirma yapilmasina olanak sagliyor.
    public record RecordType(int X,int Y);
    
    //Sadece baslangic asamasinda degerinin verilmesini istiyorsak init; anahtar sozcugunu kullaniyoruz.
    
   
}
