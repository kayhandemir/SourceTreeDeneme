using UnityEngine.SceneManagement;

public static class Deneme 
{
    public static void OyunuYukle(this EnumSinifi scene)
    {
        SceneManager.LoadScene((int)scene);
    }
}
