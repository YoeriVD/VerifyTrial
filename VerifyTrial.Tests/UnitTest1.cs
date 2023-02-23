namespace VerifyTrial.Tests;
[UsesVerify]
public class UnitTest1
{
    [Fact]
    public Task Test1()
    {
        var some = new SomeClass();
        return Verify(some.IsTrue);
    }
}