
public class Yarn: IFormattable
{
    private int needlesize, hooksize {get;}
    private string name, producername {get;}
    private YarnMaterial[] materials {get;}

    public Yarn(int needlesize, int hooksize, string name, string producername, YarnMaterial[] materials)
    {
        this.needlesize = needlesize;
        this.hooksize = hooksize;
        this.name = name;
        this.producername = producername;

        if (materials.Length() != 0)
        {
            this.materials = materials;
        } else
        {
            throw Excep
        }
    }

    public string toString()
    {
        string m = ""
        for(var i = 0; i < materials.Length(); i++)
        {
            m = m + "," + materials[i]
        }

        return producername + ";" + name + ";" + needlesize + ";" + hooksize + ";"
    }



}