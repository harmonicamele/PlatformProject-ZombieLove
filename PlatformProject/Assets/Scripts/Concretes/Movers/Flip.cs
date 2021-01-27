using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.GameFolders.Scripts.Concretes.Movers
{
    public class Flip : MonoBehaviour
    {
        public void FlipCharacter(float horizontal)
        {
            if (horizontal != 0)  //döndüğünde orada kalsın.eğer sıfıra eşit değilse bu işlemi yap.
            {
                transform.localScale = new Vector2(Mathf.Sign(horizontal), 1f);  //yönünü atadık
            }

        }
    }
}