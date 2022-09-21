namespace Assignment2.Tests;
using FluentAssertions;
using Xunit;
using System.Collections;
using System.Text;

public class ExtensionsTests
{
    [Fact]
    public void return_true_when_given_secure_uri()
    {
        // Given
        var str = "s-http://youtube.com";
        
        
        // When
        var output = Extensions.IsSecure(str);
    

        // Then
        
        output.Should().Be(true);
        
    }

    [Fact]
    public void return_false_when_given_not_secure_uri()
    {
        // Given
        var str = "http://s-http://youtube.com";
        
        
        // When
        var output = Extensions.IsSecure(str);
    

        // Then
        
        output.Should().Be(false);
        
    }

    [Fact]
    public void return_wordcount_given_string_with_words_and_symbols()
    {
        // Given
        var str = "Hi!. my name........... is,,,,,!!!?? Benjamin !!yes.maybe,true";
        
        
        // When
        var output = Extensions.WordCount(str);
    

        // Then
        output.Should().Be(8);
        
    }
}
