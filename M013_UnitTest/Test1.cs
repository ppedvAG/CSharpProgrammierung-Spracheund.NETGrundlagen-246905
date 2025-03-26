using M013_Exceptions;

namespace M013_UnitTest;

[TestClass]
public class Test1
{
    private Rechner r;

    [TestInitialize]
    public void Startup()
    {
        r = new Rechner();
    }

    [TestCleanup]
    public void CleanUp()
    {
        r = null;
    }

    //////////////////////////////////
    [TestMethod]
    [TestCategory("Addieren")]
    public void TesteAddiere()
    {
        double ergebnis = r.Addieren(4, 5);
        Assert.AreEqual(9, ergebnis);
    }
    [TestMethod]
    [TestCategory("Subtrahieren")]
    public void TesteSubtrahieren()
    {
        double ergebnis = r.Subtrahieren(4, 5);
        Assert.AreEqual(-1, ergebnis);
    }

    // Multiplizieren(5 * 7) und dividieren(49 / 7)
}
