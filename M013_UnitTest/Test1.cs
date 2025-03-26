using M013_Exceptions;

namespace M013_UnitTest;

[TestClass]
public class Test1
{
    private Rechner r;

    [TestMethod]
    public void Startup()
    {
        r = new Rechner();
    }


}
