using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour{
public void cikisbuton(){
    print("Oyundan çıkış yapıldı.");
Application.Quit();
}
public void yenioyun(){
SceneManager.LoadScene(1);
}
public void On_Value_Changed(float deger){
    print(deger);
}
public void ToggleEnabled(bool TiklandiMi){
    if(TiklandiMi){
        print("Ses aktif edildi.");
    }
    else{
        print("Ses devre dışı bırakıldı.");
    }
}
public void OnEndEditText(string metinseldeger){
    print("kullanıcı adı: "+ metinseldeger);
}
public void DropdownValue(int sayi){
    if(sayi==0){
        print("Cinsiyetiniz Kadın");
    }
    else if(sayi==1){
        print("Cinsiyetiniz Erkek");
    }
}
}