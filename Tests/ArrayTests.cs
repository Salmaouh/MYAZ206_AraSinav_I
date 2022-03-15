using System;
using Xunit;

namespace Tests
{
    // Temel amac�m�z verilen testlerin ye�ile d�nmesini sa�lamakt�r.
    // Her bir test i�in �ncelikle ald���n�z hatay� cevap ka��d�na yaz�n�z.
    // Daha sonra ald���n�z hatay� yorumlay�n�z ve hataya ili�kin olarak ��z�m �nerinizi bir ya da iki c�mle ile yaz�n�z.
    // Kod �zerinde yapt���n�z de�i�iklikleri size verilen ka��da i�leyiniz. 
    // Yaz�n�z�n olabildi�ince anla��l�r olmas�na �zen g�steriniz. 
    // Ka��d�n�z� g�revli ��retim eleman�na teslim ediniz. 
    // S�nav s�resi 45 dakikad�r.
    public class ArrayTests
    {
        [Fact]
        public void Test1()
        {
            // Arrrange
            var arr = new DataStructures.Array.Generic.Array<char>();

            // Act
            arr.SetValue('s', 0);
            arr.SetValue('a', 1);
            arr.SetValue('m', 2);
            arr.SetValue('u', 3);

            // Assert
            Assert.Collection(arr,
                item => Assert.Equal(item, arr.GetValue(0)),
                item => Assert.Equal(item, arr.GetValue(1)),
                item => Assert.Equal(item, arr.GetValue(2)),
                item => Assert.Equal(item, arr.GetValue(3)));
        }

        [Theory]
        [InlineData(5)]
        public void Test2(Object parameter)
        {
            // Arrange
            var arr = new DataStructures.Array.Array(3, 5, 7, 10);

            // Act
            var result = arr.IndexOf(parameter);

            // Assert
            Assert.Equal(arr.GetValue(1), result);
        }

        [Theory]
        [InlineData(129, "10000001")]
        [InlineData(131, "10000011")]
        [InlineData(240, "11110000")]
        [InlineData(136, "10001000")]
        [InlineData(255, "11111111")]
        public void Test3(byte input, string output)
        {
            // act
            var result = DataStructures.Logic.Logic.BinaryOutput(input);

            // assert
            Assert.Equal(result, output);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            var arr = new DataStructures.Array.Generic.Array<DateTime>(
                        DateTime.Now,
                        DateTime.Now.AddDays(1),
                        DateTime.Now.AddMonths(4)
                    );

            // Assert
            Assert.Equal(3, arr.Length);

        }

        [Theory]
        [InlineData(16)]
        [InlineData(20)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(50)]
        [InlineData(90)]
        [InlineData(500)]
        [InlineData(2000)]
        public void Test5(int length)
        {
            // Arrange
            var darr = new DataStructures.Array.ArrayList();

            // Act
            for (int i = 0; i < length; i++)
                darr.Add(i);

            var d = 0;

            // assert
            Assert.Equal(0, darr.Length);
        }

    }
}
