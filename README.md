# Matala3A-Matan

זהו משחק חלליות שצריכה להרוס את האויבים שלה. למשחק ב-itch.io לחץ כאן : [click here](https://m-h-a.itch.io/ex3-a-matan)

מקשים : A- שמאלה , D- ימינה , space - לירות
##

במשימה זו ביצעתי את ההוספות הבאות למשחק: (עשיתי את זה על ה - level 1 scene שבתקייה 4) קישור : [click here](Assets/Scenes/4-levels/level-1.unity) 


1.עשיתי שהשחקן לא יוכל לירות ללא הפסקה אלא צריך לחכות שנייה אחת בין ירייה לירייה.
 
   ב- ClickSpawner script : קישור לסקריפט - [click here](Assets/Scripts/2-spawners/ClickSpawner.cs)
 
   הגדרתי את השלושת המשתנים אלו להיות חישוב הזמן מהירייה האחרונה , איפוס הזמן אחרי כל ירייה, להגדיר זמן שאי אפשר לירות בו בין יריה לירייה בהתאמה - כפי שמוצג בתמונה.

   ![Screenshot 2024-01-23 174531](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/923f5b3e-a2f0-49b6-ab3c-c8988454c7eb)

לאחר מכן בפונקציה start עשיתי שהזמן מהירייה האחרונה שווה לזמן שלא יכול לירות, כדי שברגע שמתחיל המשחק השחקן לא יצטרך לחכות את השנייה הראשונה כדי לירות אלא ישר יחושב לו שכאילו עבר שנייה ויוכל לירות על התחלת המשחק.

![Screenshot 2024-01-23 174558](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/42903359-16ae-42f6-8201-c5ac25e049dd)

לאחר מכן בפונקציה update עשיתי שהזמן מהירייה האחרונה יתווסף לו הזמן המקורי כדי שישמש לבדיקה אם עבר הזמן דיליי שהגדרנו שאי אפשר לירות או לא. בנוסף עשיתי בדיקה שאומרת שאם לחצנו על מקש הירייה (שאצלנו הוא המקש "space") וגם שאפשר לירות (שהיא פונקציה בוליאנית שבודקת אם עבר הזמן שהגדרנו שאי אפשר לירות או לא, שמוצגת בהמשך) אז תיצור את האוביקט(שזה הלייזר) ותגדיר את המשתנה זמן הירייה האחרונה להיות הערך של איפוס הזמן(שהוא מוגדר להיות כ- 0 בהתחלה כדי שלא יהיה מספרי קסם) וכך מאפסים את הזמן כל פעם אחרי כל ירייה.

![Screenshot 2024-01-23 174611](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/27789bf6-fbf1-44be-b49c-429eecf88695)


כפי שאמרתי, יצרתי פונקציה בוליאנית שתבדוק לנו אם עבר הזמן שהגדרנו שאי אפשר לירות או לא, שעוזרת בפונקצית update.

![Screenshot 2024-01-23 174625](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/48bfe7c8-868f-49fe-94c9-7634026c4f28)


ב - LaserShooter script : קישור לסקריפט - [click here](Assets/Scripts/2-spawners/LaserShooter.cs)

בסף הכל עשיתי שאחרי שהוא יוצר את האוביקט החדש או בודק אם הוא null ומממש את שאר הפונקציה כפי שהייתה. הבדיקה הזאת חשובה כי אם מנסים לירות מתי שלא עבר הזמן שהגדרנו שאי אפשר לירות אז האוביקט הוא null וזה יעשה שגיאה בלי הבדיקה אז לכן אם הוא null נחזיר null.

![Screenshot 2024-01-23 174648](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/da2ceee6-bc8f-41c4-a297-a7a14f8b24df)

##

2.שינוי אחד מקורי שהוספתי זה שעשיתי שכל פעם שהשחקן או הלייזר מתנגש באויב יש פיצוץ.

   יצרתי מחלקה שנקראת explotion שכל מה שעושה זה להשמיד את האוביקט.

   ![Screenshot 2024-01-23 184603](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/3a373470-62e7-4bb2-a41d-5003be08c593)

   
בנוסף יצרתי עוד מחלקה בשם EnemyCollideBoom שתעשה שברגע שיש פגיעה בין השחקן לאויב או הליזר לאויב אז נראה פיצוץ ושני האוביקטים יושמדו.

![Screenshot 2024-01-23 184536](https://github.com/MHA-FinalProject/Matala3A-Matan/assets/118104946/38c3b7b7-0c5b-4929-a6bb-a3c232f94bea)

שמתי את ה scripts גם על האויב ועל הלייזר.
