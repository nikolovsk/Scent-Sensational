# Scent Sensation - онлајн парфимерија 
##### Изработено од: Ангела Николовска 213068
---------------------------------------------------------------------------------------------------------------------------------

#### Обjaснување на проблемот

Scent Sensation претставува онлајн парфимерија, место каде што можете да ги пронајдете најпознатите и најбараните парфеми, 
парфеми кои никогаш не ја губат својата вредност. Освен прикажување на парфеми по категории, оваа апликација нуди можност 
и за брзо и едноставно правење на директни нарачки.

![сц1](https://github.com/nikolovsk/Scent-Sensational/assets/129659501/184159e4-0913-4eea-9bd4-2e8001df5c9d) 

Ова е почетниот екран кој се појавува при стартување на апликацијата. Прозорецот го содржи целосното име на онлајн парфимеријата
Scent Sensation, како и кратко интро, односно визија на парфимеријата.
Корисникот има можност да избере две категории. Едната се однесува на преглед на женски парфеми, а другата се однесува на приказ 
на машки парфеми. Најдолку на формата има и дел гој што го покажува износот на направените нарачки и тој се ажурира автоматски
со секоја нова направена нарачка.

![сц2](https://github.com/nikolovsk/Scent-Sensational/assets/129659501/368fd1bb-97bc-4c84-86c7-f6d4ccc774e7)  

Ова е прозорецот кој се однесува на прикажување на листа на познати женски парфеми.
Приказот за еден запис се состои од името на парфемот, количина изразена во милилитри (мл.), достапност (дали парфемот е достапен
за нарачка или го нема на залиха), како и цената на парфемот.
Најдолу стои копче „Додади во кошничка“ кое го претставува почетниот чекор од процесот на правење на нарачката. Со кликање на 
копчето се отвара следниот прозорец подолу:

![сц4](https://github.com/nikolovsk/Scent-Sensational/assets/129659501/207b9f98-057f-43ad-aba7-5c3f1ed1f2d3)  

Овој прозорец содржи едно текст поле, според кое се пребарува парфемот според внесеното име на парфемот од страна на корисникот.
Со клик на копчето „Додади“ се отвара следниот прозорец,

![сц5](https://github.com/nikolovsk/Scent-Sensational/assets/129659501/45489f59-2749-4da3-a2a7-1f130664613f)  

кој што служи за потврда на нарачката.
Корисникот може да ја потврди нарачката со клик на копчето или да го исклучи стандардно прозорецот, со што не би се извршила 
никаква нарачка. Доколку избере да ја потврди нарачката, се отвара следниот прозорец со кратка порака до корисникот со кој му се 
заблагодаруваат за довербата.

![сц6](https://github.com/nikolovsk/Scent-Sensational/assets/129659501/e0bcadd9-11b7-440d-a1fc-e07ce5fdee35)    

Истиот процес се однесува и со избирање на машка категорија од почетниот екран, со таа разлика што наместо женски парфеми,
на екранот се прикажани познати машки парфеми, соодветно.

![сц3](https://github.com/nikolovsk/Scent-Sensational/assets/129659501/9bddbe61-49aa-4f85-b6fe-4c2f4cc51a0d)  


-------------------------------------------------------------------------------------------------------------------------------------- 
#### Решение на проблемот (Имплементација) 

Имплементирана е класа Perfume, во која се чуваат податоците за парфемите и тоа:  
  -> Име на парфемот, од тип String  
  -> Милилитри (количина), од тип int  
  -> Мирисна група на парфемот, од тип String  
  -> Достапност, од тип String  
  -> Цена, од тип int  
Во оваа класа е преоптоварен ToString методот, за печатење на парфемите на зададен начин.  

Во класите Male perfumes и Woman Perfumes има листа со парфеми, која се користи за прикажување на парфемите и информациите за нив
на екранот, како што претходно видовме на формите.
Овие класи имаат и два методи, AddMalePerfumesToList() / AddWomanPerfumesToList() со кои се полни листата, односно се додаваат записи
во истата, и метод ShowPerfumes() со кој се печатат парфемите од листата соодветно.
Исто така, имплементиран е и методот btnAddToCart_Click(object sender, EventArgs e) за приказ на нов прозорец за правење на нарачка,
т.е. со кликање на ова копче се отвара формата Add to cart. Нејзината имплементација се состои од еден единствен метод 
buttonAdd_Click(object sender, EventArgs e) со кој се покажува нов прозорец за потврдување на нарачката.

Последната класа која се однесува на главната форма, односно на почетниот екран содржи две листи на парфеми, една за машки и една за
женски парфеми соодветно и методи btnWomanCategory_Click(object sender, EventArgs e) и btnMaleCategory_Click(object sender, EventArgs e)
со кои се прави повик на прозорците за приказ на парфемите од листите.
Исто така, има и метод updateTotalAmount() кој помага за ажурирање на вкупниот износ на нарачките, поле кое што се наога долу лево на
почетниот екран, како што видовме и претходно.
