# 🚀 C# Soket Chat Uygulaması

Bu proje, C# ve .NET kullanarak temel bir soket programlama örneğidir. TCP/IP üzerinden çalışan bir sunucu (Server) ve bu sunucuya bağlanabilen birden fazla istemciden (Client) oluşan basit bir konsol tabanlı chat uygulamasıdır.

Bu projenin temel amacı, ağ programlama temellerini (özellikle `TcpListener` ve `TcpClient` sınıflarını) ve C#'ta asenkron programlamayı (`async/await`, `Task`) anlamak ve uygulamalı bir örnek sunmaktır.

## ✨ Özellikler

* **Merkezi Sunucu:** Tüm istemcilerin bağlandığı ve mesaj trafiğini yöneten bir sunucu.
* **Çoklu İstemci Desteği:** Sunucu, aynı anda birden fazla istemci bağlantısını kabul edebilir ve yönetebilir.
* **Asenkron İşlem:** `async/await` kullanılarak engellemeyen (non-blocking) G/Ç işlemleri gerçekleştirilmiştir. Sunucu, bir istemciyi dinlerken diğerlerini bekletmez.
* **Mesaj Yayını (Broadcast):** Bir istemciden gelen mesaj, sunucuya bağlı olan diğer tüm istemcilere (gönderen hariç) iletilir.
* **Bağlantı Yönetimi:** Yeni bağlanan ve bağlantısı kopan istemciler sunucu tarafından tespit edilir ve yönetilir.
* **Konsol Arayüzü:** Hem sunucu hem de istemci basit konsol uygulamaları olarak çalışır.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Platform:** .NET (Core / 5 / 6 / 7 / 8+)
* **Ana Sınıflar:**
    * `System.Net.Sockets.TcpListener`: Sunucu tarafında gelen bağlantıları dinlemek için.
    * `System.Net.Sockets.TcpClient`: İstemci tarafında sunucuya bağlanmak ve sunucu tarafında istemciyi temsil etmek için.
    * `System.Net.Sockets.NetworkStream`: Soket üzerinden veri okuma ve yazma işlemleri için.
    * `System.Threading.Tasks.Task`: Her istemci iletişimini ayrı bir görev üzerinde asenkron olarak yürütmek için.

## 🏁 Kurulum ve Çalıştırma

Bu projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyebilirsiniz.

### Gereksinimler

* [.NET SDK](https://dotnet.microsoft.com/download) (Projenin oluşturulduğu sürüm veya daha yenisi, örn: .NET 6.0+)
* [Visual Studio 2022](https://visualstudio.microsoft.com/) (Önerilir) veya [Visual Studio Code](https://code.visualstudio.com/)

### Adımlar

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/KULLANICI_ADINIZ/PROJE_ADINIZ.git](https://github.com/KULLANICI_ADINIZ/PROJE_ADINIZ.git)
    cd PROJE_ADINIZ
    ```

2.  **Projeyi Açın:**
    `ChatApp.sln` (veya benzeri) çözüm dosyasını Visual Studio ile açın.

3.  **Sunucuyu Başlatın:**
    * Visual Studio'da `Server` (veya `ChatServer`) projesini "Başlangıç Projesi" (Set as Startup Project) olarak ayarlayın.
    * Projeyi `Ctrl+F5` (Hata ayıklama olmadan başlat) veya `F5` (Hata ayıklama ile başlat) tuşlarına basarak çalıştırın.
    * Konsolda "Sunucu ... adresinde dinlemede..." mesajını görmelisiniz.

    *Veya Komut Satırından:*
    ```bash
    dotnet run --project Server/Server.csproj
    ```

4.  **İstemcileri Başlatın:**
    * Sunucu çalışır durumdayken, `Client` (veya `ChatClient`) projesini başlatmanız gerekir.
    * **Visual Studio İpucu:** Çözüm (Solution) üzerine sağ tıklayın -> "Properties" (Özellikler) -> "Common Properties" -> "Startup Project" -> "Multiple startup projects" seçeneğini seçin. Buradan hem `Server` hem de `Client` projesinin "Action" (Eylem) sütununu "Start" (Başlat) olarak ayarlayabilirsiniz. Bu sayede tek tıkla hem sunucuyu hem de bir istemciyi başlatabilirsiniz.
    * **Daha fazla istemci için:** `Client` projesini birden çok kez başlatın (Visual Studio'da proje adına sağ tıklayıp "Debug" -> "Start new instance" diyebilir veya komut satırından aşağıdaki komutu birden fazla terminalde çalıştırabilirsiniz).

    *Veya Komut Satırından (Yeni Terminal Pencerelerinde):*
    ```bash
    dotnet run --project Client/Client.csproj
    ```

5.  **Test Edin:**
    * Her istemci bağlandığında sunucu konsolunda "Yeni bir istemci bağlandı!" mesajını göreceksiniz.
    * İstemci konsollarına kullanıcı adınızı girin.
    * Bir istemciden mesaj yazdığınızda, bu mesajın diğer tüm istemci konsollarına iletildiğini göreceksiniz.

## 📁 Proje Yapısı (Örnek)
