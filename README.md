# Picker3DClone

Picker 3D oyununun kendi versiyonumu yaptığım bir çalışma oldu. Oyundaki amaç; toplama objesiyle olabildiğince top toplayıp, platformun sonundaki bölmelere istenilen miktarda veya daha fazla olacak şekilde top getirmektir.

Her level 3 aşamadan oluşmaktadır. 10 level tasarımı yapıldı. 10.leveldan sonra random olacak şekilde levellar sonsuza kadar devam etmektedir. Oyunda palet, ekstra toplar ve sayım için ekstra 5 puan veren itemler de vardır. Ayrıca her levelda, finish çizgisine ne kadar mesafe kaldığını gösteren bir ilerleme barı da mevcuttur. Hareket hem mouse ile sürükleyerek hem de klavyedeki sağ ve sol yön oklarıyla olmak üzere iki şekilde de sağlanabilmektedir. Tercih kullanıcıya bırakılmıştır. Ayrıca projede, oyundan çıkılsa bile tekrar açıldığında oyuna kalınan leveldan devam eden bir kayıt sistemi de mevcuttur.

Bölmeye istenilen miktarda top getirilemezse Game Over panelinde kullanıcıya seçenek olarak sunulan, reklam izleyerek bölmeyi geçmesini sağlayan bir Rewarded Ads sistemi mevcuttur. Ayrıca levellar arası geçişte ekrana gelecek şekilde Interstitial Ads sistemi de projeye entegre edilmiştir.

Tasarımsal açıdan kolaylık sağlaması için, editor sahnesinde bulunan GameManager adlı objenin scriptleri aracılığıyla, bu objenin inspectorundan; sahneye yeni level eklenmesi, mevcut levellar arası geçiş yapılabilmesi, yeni objelerin eklenmesi/silinmesi ve bölmeler arası geçişi belirleyen top miktarının isteğe göre değiştirilebilir hale getirilmesi sağlanmıştır.

## Screenshots

![Ekran Görüntüsü (3)](https://user-images.githubusercontent.com/102216059/195270113-b8e854a5-f9b1-4ecc-93f7-954aab64e784.png)
![Ekran Görüntüsü (5)](https://user-images.githubusercontent.com/102216059/195270125-a692ef99-ede9-4b69-af38-4a1b84e2949f.png)
![Ekran Görüntüsü (6)](https://user-images.githubusercontent.com/102216059/195270128-bea4575a-b148-4f69-a07a-d4b794181dc3.png)
![Ekran Görüntüsü (10)](https://user-images.githubusercontent.com/102216059/195270141-017ed39a-2de3-45cb-9b85-27374099204e.png)
![Ekran Görüntüsü (11)](https://user-images.githubusercontent.com/102216059/195270148-85a27236-0f66-4229-bab4-eb4fa644946b.png)
![Ekran Görüntüsü (12)](https://user-images.githubusercontent.com/102216059/195270152-331f78d3-6960-40f9-b448-dca480e3cb84.png)
![Ekran Görüntüsü (13)](https://user-images.githubusercontent.com/102216059/195270159-2f11e6d1-1b06-4ecd-bb4b-56e1ae4dfdea.png)
![Ekran Görüntüsü (14)](https://user-images.githubusercontent.com/102216059/195270165-386bc28a-9f93-4c0a-ba9b-7e2404b60208.png)
![Ekran Görüntüsü (9)](https://user-images.githubusercontent.com/102216059/195270132-136ae326-5ce1-46c1-b17f-bd77ceb6f017.png)
![Ekran Görüntüsü (15)](https://user-images.githubusercontent.com/102216059/195270168-dfb61011-3952-4439-a083-1c68180c7fcb.png)
