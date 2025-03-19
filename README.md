
# Diagrama Logica

![image](https://github.com/user-attachments/assets/e3656800-dc81-41c1-b7f9-74e3457ad2b0)



# Design Mock-up

![image](https://github.com/user-attachments/assets/1c603b4f-7282-4355-b447-438ef062889d)


# Stack de technologii
   Versiune .NET: 8.0
   
   Limbaje de programare: C#
   
   Interfata grafica: Windows Forms
# Structura Aplicatiei
Solutia este formata din 2 proiecte :

-> **Solutie_Backend_Proiect_Restaurant_N** : Acest proiect este un proiect de tip librarie de clase. Acesta contine clasa Ingredient si IngredientMenu, care impreuna gestioneaza datale si stocarea lor.

-> **Solutia_Frontend_Proiect_Restaurant_N** : Acest proiect este un proiect de tip Windows Forms Application. Acesta contine mai multe formulare Forms si UserControls.

# Limitari 
Aplicatia nu dispune de mecanism de import / export de date. Meniul de ingrediente este pre-populat in aplicatie.
![image](https://github.com/user-attachments/assets/4bab1ce3-b555-4b33-8106-65a060a36e49)


# Prezentarea Aplicatiei Grafice 

**Primul form : MainMenu** 

 Ii permite utilizatorului sa :
 - vizualizeze meniul cu felurile de mancare, sub forma de lista
 - sa adauge in lista utilizatorului, felul de mancare dorit (prin apasarea butonului + din dreptul fiecarui fel de mancare din lista)
 - sa poata inchide primul form prin butonul **Close**

**Al doilea form : MyList**
- utilizatorul poate vizualiza felurile de mancare pe care le-a adaugat in lista lui
- utilizatorul poate scoate din lista sa un fel de mancare (prin apasarea butonului - din dreptul fiecarui fel de mancare din lista)
- inchiderea form-lui prin butonul **Close**
- putem trimite comanda prin apasarea butonului **Order Now** care ne deschide un nou form **DataDelivery**

**Al treilea form : DataDelivery**
- utilizatorul trebuie sa introduca detalii legate de nume, adresa si metoda de plata dorita
- daca nu introducem unul din campurile din acet form, avem un mesaj de atentionare, care ne indica campurile care au ramas necompletate.
- inchiderea form-lui prin butonul **Close**
- butonul **Order** trimite comanda si un messageBox care ne indica "Comanda a fost plasata!!"
  
 
