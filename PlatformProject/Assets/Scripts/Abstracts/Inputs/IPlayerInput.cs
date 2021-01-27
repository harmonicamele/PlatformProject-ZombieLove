using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.GameFolders.Scripts.Abstracts.Inputs
{
    public interface IPlayerInput // bu bi class değil o yüzden inteface alıcak.pcınput ve mobile bu interfaceden miras alacak
    {
        float Horizontal { get; }
        bool isJumpButton { get; }

        bool isrun { get; }
        
    }
}