# Matala3A-Matan

זהו משחק חלליות שצריכה להרוס את האויבים שלה. למשחק לחץ כאן : [click here](https://m-h-a.itch.io/ex3-a-matan)
##

במשימה זו ביצעתי את ההוספות הבאות למשחק:

1.עשיתי שהשחקן לא יוכל לירות ללא הפסקה אלא צריך לחכות שנייה אחת בין ירייה לירייה.
 
   ב- ClickSpawner script :

   הגדרתי את השלושת המשתנים אלו להיות חישוב הזמן מהירייה האחרונה , איפוס הזמן אחרי כל ירייה, להגדיר זמן שאי אפשר לירות בו בין יריה לירייה בהתאמה - כפי שמוצג בתמונה.

   ![Screenshot 2024-01-23 174531](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/923f5b3e-a2f0-49b6-ab3c-c8988454c7eb)

לאחר מכן בפונקציה start עשיתי שהזמן מהירייה האחרונה שווה לזמן שלא יכול לירות, כדי שברגע שמתחיל המשחק השחקן לא יצטרך לחכות את השנייה הראשונה כדי לירות אלא ישר יחושב לו שכאילו עבר שנייה ויוכל לירות על התחלת המשחק.

![Screenshot 2024-01-23 174558](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/42903359-16ae-42f6-8201-c5ac25e049dd)

לאחר מכן בפונקציה update עשיתי שהזמן מהירייה האחרונה יתווסף לו הזמן המקורי כדי שישמש לבדיקה אם עבר הזמן דיליי שהגדרנו שאי אפשר לירות או לא. בנוסף עשינו בדיקה שאומרת שאם לחצנו על מקש הירייה (שאצלנו הוא המקש "space") וגם שאפשר לירות (שהיא פונקציה בוליאנית שבודקת אם עבר הזמן שהגדרנו שאי אפשר לירות או לא שמוצגת בהמשך) אז תיצור את האוביקט(שזה הלייזר) ותגדיר את המשתנה זמן הירייה האחרונה להיות הערך של איפוס הזמן(שהוא מוגדר להיות כ- 0 בהתחלה כדי שלא יהיה מספרי קסם) וכך מאפסים את הזמן כל פעם אחרי כל ירייה.

![Screenshot 2024-01-23 174611](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/27789bf6-fbf1-44be-b49c-429eecf88695)



