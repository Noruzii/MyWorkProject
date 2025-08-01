# Unity Child Relaxation Room

این پروژه یک صحنه آرامش‌بخش و تعاملی برای کودکان ۳ تا ۷ سال را در Unity پیاده‌سازی می‌کند. هدف اصلی، ارزیابی توانایی‌های توسعه‌دهنده در طراحی تجربه کاربری کودک‌محور، پیاده‌سازی تعاملات ساده، و کار با محتوای دینامیک از طریق API است.

---

## ۱. نحوه پیاده‌سازی و معماری پروژه

**معماری MVP (Model-View-Presenter): هسته اصلی طراحی**

تمام تعاملات اصلی کاربر با اشیاء در این پروژه بر اساس الگوی طراحی **Model-View-Presenter (MVP)** پیاده‌سازی شده است. این رویکرد، جداسازی مسئولیت‌ها را تضمین می‌کند و به توسعه‌پذیری و نگهداری آسان‌تر کد کمک می‌کند.

**اصول SOLID و برنامه‌نویسی شیءگرا (OOP): پایه‌های یک کد تمیز**

در توسعه این پروژه، اصول **SOLID** و مفاهیم **برنامه‌نویسی شیءگرا (OOP)** به‌طور کامل رعایت شده‌اند. این امر منجر به کدی ماژولار، انعطاف‌پذیر و قابل آزمایش شده است.

**ساختار سلسله‌مراتبی MVP با وراثت:**

برای پیاده‌سازی کارآمد MVP، سه کلاس والد پایه تعریف شده‌اند:
* `Model`
* `View`
* `Presenter`

هر آبجکت تعاملی در صحنه، دارای سه کلاس اختصاصی است که از این کلاس‌های والد ارث‌بری می‌کنند. به عنوان مثال، برای یک آبجکت به نام "Name"، کلاس‌های زیر وجود دارند:
* `NameView` (ارث‌بری از `View`)
* `NameModel` (ارث‌بری از `Model`)
* `NamePresenter` (ارث‌بری از `Presenter`)

این ساختار، مدیریت رفتار و داده‌های هر آبجکت را به صورت کاملاً تفکیک شده و سازمان‌یافته امکان‌پذیر می‌سازد.

**سیستم ورودی نوین Unity:**

برای مدیریت تعاملات کاربری (مانند کلیک)، از **Input System جدید Unity** استفاده شده است که رویکردی مدرن‌تر و منعطف‌تر برای پردازش ورودی‌ها ارائه می‌دهد.

**مدیریت حالت بازی با الگوی Observer:**

قابلیت سوئیچ کردن بین حالت‌های احساسی مختلف (آرام و ناآرام) در بازی، با پیاده‌سازی متد `SetState` و استفاده از الگوی طراحی **Observer** انجام شده است. این الگو تضمین می‌کند که هر بخش از سیستم که به تغییر حالت‌ها نیاز دارد، به‌طور خودکار مطلع و به‌روزرسانی شود.# Unity Child Relaxation Room

این پروژه یک صحنه آرامش‌بخش و تعاملی برای کودکان ۳ تا ۷ سال را در Unity پیاده‌سازی می‌کند. هدف اصلی، ارزیابی توانایی‌های توسعه‌دهنده در طراحی تجربه کاربری کودک‌محور، پیاده‌سازی تعاملات ساده، و کار با محتوای دینامیک از طریق API است.

---

## ۱. نحوه پیاده‌سازی و معماری پروژه

**معماری MVP (Model-View-Presenter): هسته اصلی طراحی**

تمام تعاملات اصلی کاربر با اشیاء در این پروژه بر اساس الگوی طراحی **Model-View-Presenter (MVP)** پیاده‌سازی شده است. این رویکرد، جداسازی مسئولیت‌ها را تضمین می‌کند و به توسعه‌پذیری و نگهداری آسان‌تر کد کمک می‌کند.

**اصول SOLID و برنامه‌نویسی شیءگرا (OOP): پایه‌های یک کد تمیز**

در توسعه این پروژه، اصول **SOLID** و مفاهیم **برنامه‌نویسی شیءگرا (OOP)** به‌طور کامل رعایت شده‌اند. این امر منجر به کدی ماژولار، انعطاف‌پذیر و قابل آزمایش شده است.

**ساختار سلسله‌مراتبی MVP با وراثت:**

برای پیاده‌سازی کارآمد MVP، سه کلاس والد پایه تعریف شده‌اند:
* `Model`
* `View`
* `Presenter`

هر آبجکت تعاملی در صحنه، دارای سه کلاس اختصاصی است که از این کلاس‌های والد ارث‌بری می‌کنند. به عنوان مثال، برای یک آبجکت به نام "Name"، کلاس‌های زیر وجود دارند:
* `NameView` (ارث‌بری از `View`)
* `NameModel` (ارث‌بری از `Model`)
* `NamePresenter` (ارث‌بری از `Presenter`)

این ساختار، مدیریت رفتار و داده‌های هر آبجکت را به صورت کاملاً تفکیک شده و سازمان‌یافته امکان‌پذیر می‌سازد.

**اشیاء تعاملی و سیستم ورودی نوین Unity:**

در این صحنه، **فقط کاراکتر کودک و چراغ شب‌خواب** اشیاء قابل تعامل هستند. برای مدیریت تعاملات کاربری (مانند کلیک)، از **Input System جدید Unity** استفاده شده است که رویکردی مدرن‌تر و منعطف‌تر برای پردازش ورودی‌ها ارائه می‌دهد. با **کلیک چپ ماوس** روی این اشیاء، رویدادهای مشخصی فعال می‌شوند:
* **کاراکتر کودک:** با کلیک چپ ماوس، یک صدای ملایم و آرامش‌بخش پخش می‌شود.
* **چراغ شب‌خواب:** با کلیک چپ ماوس، وضعیت آن بین روشن و خاموش تغییر می‌کند.

**مدیریت حالت بازی با الگوی Observer:**

قابلیت سوئیچ کردن بین حالت‌های احساسی مختلف (آرام و ناآرام) در بازی، با پیاده‌سازی متد `SetState` و استفاده از الگوی طراحی **Observer** انجام شده است. این الگو تضمین می‌کند که هر بخش از سیستم که به تغییر حالت‌ها نیاز دارد، به‌طور خودکار مطلع و به‌روزرسانی شود.

## نحوه اجرای پروژه

در برخورد اول، شما با **محیط اصلی بازی** و **دو منوی کلیدی** مواجه می‌شید:

* **منوی انتخاب داستان:** این منو به شما امکان می‌ده تا لیست داستان‌های کودکانه موجود را مشاهده کرده و داستان مورد نظر خود را انتخاب کنید.
* **منوی تغییر حالت (Mood Switcher):** از طریق این منو می‌توانید بین **دو حالت احساسی** اصلی بازی (آرام و ناآرام) سوئیچ کنید.

**وضعیت اولیه بازی** به صورت پیش‌فرض روی **حالت آرام** تنظیم شده است. شما می‌تونید از طریق **منوی تغییر حالت**، وضعیت بازی رو بین **آرام** و **ناآرام** تغییر بدید. پس از انتخاب حالت مورد نظر، با **کلیک چپ ماوس** روی **کاراکتر کودک** و **چراغ شب‌خواب**، می‌تونید **تغییرات و تأثیرات** حالت انتخابی رو در تعامل با این اشیا مشاهده کنید.


## توضیح نحوه اتصال به API فرضی

در این پروژه، برای دریافت لیست داستان‌های کودکانه، از یک **API فرضی شبیه‌سازی شده** استفاده شده است. این رویکرد نیاز به پیاده‌سازی یک بک‌اند واقعی را از بین می‌برد و تمرکز را بر توانایی ارتباط با داده‌های دینامیک در Unity حفظ می‌کند.

* **منبع داده API:**
    * داده‌های مربوط به داستان‌ها در یک فایل **JSON** با نام `stories.json` ذخیره شده‌اند.
    * این فایل در پوشه **`Assets/StreamingAssets/`** در پروژه Unity قرار دارد. پوشه `StreamingAssets` به Unity اجازه می‌دهد تا فایل‌های مشخصی را در زمان اجرا به سادگی لود کند.
    * **ساختار فایل `stories.json`:**
        ```json
        {
          "stories": [
            {
              "id": "1",
              "title": "The Playful Rabbit's Adventure",
              "description": "A little rabbit who was looking for his friends in the forest and had many adventures."
            },
            {
              "id": "2",
              "title": "The Kind Little Elephant",
              "description": "A small pink elephant who always helped his friends in the jungle and had a big heart."
            },
            {
              "id": "3",
              "title": "The Magical Singing Bird",
              "description": "A blue bird that made trees green and flowers bloom with its song."
            }
          ]
        }
        ```
        * *(اگر از فایل‌های صوتی استفاده می‌کنی، خط `audio_url` را با مسیر فایل صوتی در `StreamingAssets/audio/` به هر آیتم اضافه کن.)*

* **دریافت داده‌ها در Unity:**
    * اسکریپت **`StoryDataLoader.cs`** (که به یک `GameObject` در صحنه متصل است) مسئول دریافت این فایل JSON است.
    * این اسکریپت از **`UnityEngine.Networking.UnityWebRequest`** برای خواندن محتوای `stories.json` استفاده می‌کند.
    * پس از دریافت، داده‌های JSON با استفاده از **`UnityEngine.JsonUtility.FromJson<T>`** به مدل‌های C# (`StoryData` و `StoryList`) تبدیل می‌شوند.
    * یک الگوی **Singleton** ساده برای `StoryDataLoader` پیاده‌سازی شده تا دسترسی به `Instance` آن در سراسر پروژه آسان باشد و از مقداردهی‌های تکراری جلوگیری شود.

* **نمایش داستان‌ها در رابط کاربری:**
    * اسکریپت **`StoryDisplayUI.cs`** به رویداد `OnStoriesLoaded` از `StoryDataLoader` گوش می‌دهد.
    * پس از دریافت داده‌های داستان، این اسکریپت به صورت دینامیک آیتم‌های UI (Prefab) را برای هر داستان در یک `Scroll View` ایجاد و نمایش می‌دهد.
    * **تعامل:** با کلیک روی هر عنوان داستان، **توضیحات کامل** آن در یک پنل جداگانه (با قابلیت بسته شدن) نمایش داده می‌شود.
