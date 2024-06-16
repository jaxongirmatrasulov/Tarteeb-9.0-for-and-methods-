# Tarteeb-9.0-for-and-methods-

># while and for ni bir-biridan farqi.

while bu oxirgi natijasi nomalum bolgan hollarda yani foydalanuvchidan biz qiymat soraganimizda qabul qilganimizda foydalansak  juda chiroyli boladi.

for dan esa boshlanish ham tugash nuqtalari qiymati malum hollarda biz fordan foydalanar ekanmiz.

ikkala holatham biz uchun juda muhum.

> ARRAYS

string[] ==> qiymatlarni royxati desak ham boladi.

string[] cars => {"bmw", "mazda", "ford", "gm", "mers"} ==> quydagi korinishda boladi.

array larda qiymatlarni qaysi orinda turishini aniqlashimiz uchun biz quydagicha yoldan foydalanamiz.

Console.WriteLine(cars[0]); bizga natija "bmw" chiqadi. chunki arraylarda qiymatlarni joylashuvi 0 dan boshlab sanaladi va hisoblanadi. yani cars arrayimizda 0 chi orinda "bmw" bosa 4 chi orinda "mers" turgan boladi.

# arraylarni yasalishini 4 ta turi bor lekin eng muhim turi biz bilshimiz kerak bolgani bu 2 ta va ular quydagilar.

string[] cars = new string[4]; => bu holatda qiymatlar soni malum lekin qiymat nomalum hollar uchun.

int[] myNum = {10, 20, 30, 40, 50}; => bu odatiy holat yani qiymatlar soni va qiymat malum.

># array bilan foydalanadigan tiplar.

__1__ 
Array.Sort(cars) => bu arrayni osish ketma-ketligida togirlab beradi.

__2__
int[] myNum = {9, 4, 3, 45, 6};

Array.Sort(myNum);

foreach(int i in myNum)

{

    Console.WriteLine(myNum);

}

natija : (3, 4, 6, 9, 45);


># C# metodlari

static void SalomAyt()  => bu hech nima qabul qilmayabdi va qaytarmayabdi.

{

    Console.WriteLine("salom");
}


static string SuvKeltir(decimal pul)

{

    return $"suv: {pul}" ;
}

># method signature => metod imzosi.

static void ShowMessage(int message)

{

    console.writeline(message);
}


static void ShowMessage(string message)

{

    console.writeline(message);
}


tepadagi holatda bir xil nomli ammo har hil imzoli metodlarni koryapmiz. 

!!!!! Agarda bizda imzolar yani qabul qiluvchi qiymat turlari harhil boladigan bolsa biz hohlaganimizcha metod yozishimiz mumkin ekan. 

**Bu xolatda biz bir xil nomli ikki xil imzoli metodlar yaratganmiz va buni biz "overload" qilgan bolamiz**