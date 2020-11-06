using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public RenderTexture main_tex;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Temporary code to clear the render texture
        if(Input.GetKey(KeyCode.C))
        {
            ClearActiveRenderTexture(main_tex);
        }
    }
    public void ClearActiveRenderTexture(RenderTexture tex)
    {
        /*RenderTexture rt = RenderTexture.active;
        RenderTexture.active = tex;
        GL.Clear(true, true, Color.clear);
        RenderTexture.active = rt;*/
        /*Release (in this case, we'r trying to clear the current render texture.
         It's recommended to release the render texture whenever we finished using them.
        */
        tex.Release();
    }
}
