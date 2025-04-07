# Programma per esercitarsi sui quiz della patente nautica

Urbino`s University - Applied computer science - Apprenticeship

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=black)

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/b4af2e490af64e028444bc9114d6222d)](https://app.codacy.com/gh/R0mb0/NauticalProgramQuizzes/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)

[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://github.com/R0mb0/Social-Network-Analysis-project)
[![Open Source Love svg3](https://badges.frapsoft.com/os/v3/open-source.svg?v=103)](https://github.com/R0mb0/Social-Network-Analysis-project)

[![Donate](https://img.shields.io/badge/PayPal-Donate%20to%20Author-blue.svg)](http://paypal.me/R0mb0)

## Attivazione del programma

### Lato utente

- Una volta scaricato ed avviato il programma, ci si trova nella schermata di attivazione che si compone di due riquadri ("Nome utente" e "Codice attivazione") ed un pulsante ("Attiva").  
- Comunicare al fornitore del programma il nome utente riportato dalla schermata e attendere il codice di attivazione.  
- Una volta ottenuto il codice di attivazione questo va copiato nel riquadro "Codice attivazione".  
- Premere quindi il pulsante "Attiva" per attivare il programma.  

### Lato Fornitore

- Aprire il programma "Code generator". Il pannello del programma si compone di due riquadri ("Nome utente" e "Codice attivazione") ed un pulsante ("Genera codice di attivazione").  
- Inserire nel riquadro "Nome Utente" il nome passato dal cliente.
- Una volta inserito il nome utente premere il pulsante "Genera codice di attivazione" per generare il codice da comunicare al cliente.  

## Composizione del programma

### Pannello principale

Una volta aver avviato il programma ci si trova nel pannello principale, dove sono presenti tre pulsanti: il primo ("Simulazione compito d'esame") una volta cliccato avvierà una finestra ("Simulazione quiz patente nautica"), all'interno della quale sarà possibile fare delle simulazioni dei quiz dell'esame, ma anche esercitarsi sulla singole domande (ad esempio quelle sbagliate durante una simulazione) tramite il pulsante "Cerca domanda". Il secondo pulsante ("Esercitazione quiz d'esame") apre una finestra ("Domande patente nautica") nella quale sarà possibile esercitarsi con i quiz divisi in capitoli a seconda del argomento. L'ultimo pulsante ("Modifica i quiz") avvia una finestra ("Editor dei quiz") all'interno della quale è possibile modificare i quiz precaricati su un database locale.  

### Simulazione quiz patente nautica

La finestra è composta da due livelli: il livello inferiore è quello nel quale vengono mostrate le domande, si compone di cinque riquadri e tre pulsanti e uno spazio immagine. I riquadri che mostrano la domanda e le sue proprietà sono di colore verde chiaro, quelli che mostrano le tre risposte da scegliere sono di colore azzurrino e il riquadro immagine è di colore nero.  
Il primo riquadro verde chiaro (a partire da sinistra) mostra il numero della domanda, a seguire troviamo la domanda. Sotto il riquadro del numero della domanda ci sono tre pulsanti per la scelta della risposta. Per rispondere alla domanda è sufficiente cliccare con il tasto sinistro del mouse il pulsante corrispondente alla risposta che si vuole dare.  
L'ultimo riquadro (di colore nero) serve per visualizzare l'immagine del quiz.  
Nel livello superiore di colore rosa chiaro troviamo, partendo da sinistra, due pulsanti che regolano lo stato del programma ("Start" e "Stop"), sotto troviamo altri 2 pulsanti che ci permettono di procedere avanti o indietro con le domande ("Domanda precedente" e "Domanda successiva"); procedendo verso destra si trovano i contatori, "Domande" che mostra l'indice della domanda corrente rispetto al totale, "Domande giuste" che mostra il numero di domande a cui si è risposto correttamente. Le domande a cui non si è risposto in maniera corretta vengono contate in "Domande sbagliate". Sopra ai contatori si trova "lo stato della prova" che diventa verde se la simulazione è stata superata, rossa se non è stata superata, a seguire troviamo il pulsante "Cerca Domanda" con di fianco il riquadro dove poter inserire il numero di domanda da cercare; procedendo verso destra troviamo due pulsanti, ("Entro 12 miglia" e "Oltre 12 miglia") che permettono di selezionare la categoria di simulazione che si desidera fare.  

### Domande patente nautica

La finestra è composta da due livelli: nel livello inferiore vengono mostrate le domande, si compone di cinque riquadri, tre pulsanti e uno spazio immagine. I riquadri che mostrano la domanda e le sue proprietà sono di colore verde chiaro, quelli che mostrano le tre risposte da scegliere sono di colore azzurrino e il riquadro immagine è di colore nero.  
Il primo riquadro verde chiaro (a partire da sinistra) mostra il numero della domanda, a seguire troviamo la domanda. Sotto il riquadro del numero della domanda ci sono tre pulsanti per la scelta della risposta. Per rispondere alla domanda è sufficiente cliccare con il tasto sinistro del mouse il pulsante corrispondente alla risposta che si vuole dare.  
L'ultimo riquadro (di colore nero) mostra l'eventuale immagine del quiz.  
Nel livello superiore di colore rosa chiaro troviamo un menù a tendina che permette di selezionare il capitolo delle domande per le quali ci si vuole esercitare; immediatamente sotto ci sono due pulsanti che ci permettono di procedere avanti o indietro con le domande ("Domanda precedente" e "Domanda successiva"); a seguire troviamo i contatori: "Domande" (mostra il numero della domanda corrente) "Domande giuste" (mostra il numero di domande a cui si è risposto correttamente) "Domande sbagliate" (mostra il numero delle domande a cui non si è risposto correttamente). Sopra ai contatori troviamo il riquadro del capitolo scelto; procedendo verso destra ci sono due pulsanti, "Start" e "Stop" che permettono, dopo aver scelto il capitolo sul quale ci si vuole esercitare, di iniziare o interrompere la prova.  

### Editor dei quiz

Questa finestra come le precedenti si compone di due livelli, nel livello inferiore è possibile inserire e modificare le domande (riquadro verde chiaro) e le risposte (riquadri azzurrini). Trasportando un'immagine sul riquadro nero è possibile inserire un'immagine alla domanda. Sotto questo riquadro sono presenti due pulsanti, "Inserisci/salva Quiz" serve per salvare il quiz, il pulsante "Salva Database" serve per salvare fisicamente sulla memoria del pc le modifiche fatte alle domande.
Nel livello superiore (di colore rosa chiaro) è possibile scegliere la categoria di quiz che si vuole modificare ("Entro 12 Miglia" o "Oltre 12 Miglia"), si scorre tra le domande, si inserisce la risposta giusta e si cancella l'immagine qualora fosse sbagliata.  
In alto troviamo il riquadro "Stato del quiz" che si colora di verde se la domanda è presente all'interno della memoria, si colora di rosso se la domanda non è ancora stata salvata. Sotto sono presenti due tasti ("Domanda precedente" e "Domanda successiva") che permettono di navigare tra le domande. Il riquadro "risposta giusta" permette di inserire/modificare (con un valore da 1 a 3) il numero di risposta giusta. A fianco di esso verso destra è presente il pulsante che permette di cancellare l'immagine ("Cancella immagine"), proseguendo verso destra troviamo l'indice della domanda (campo "Domande") nel quale è possibile vedere rispetto al totale l'indice della domanda corrente. Nel secondo riquadro (quello più basso) definito "Domande" è possibile inserire l'indice della domanda che si vuole modificare, e tramite il pulsante posto a sinistra del suddetto ("Cerca domanda") è possibile raggiungere la domanda inserita nell'indice digitato. Con pulsanti "Entro 12 miglia" e "Oltre 12 miglia" è possibile selezionar la categoria di quiz del quale si vogliono modificare le domande.  

## Come usare il programma

### Come fare una simulazione della prova d'esame  

Una volta aver avviato la finestra "Domande patente nautica".  
- Selezionare il tipo di quiz che s'intende fare (entro/oltre le 12 miglia), a selezione fatta il pulsante premuto si illuminerà di colore verde.  
- Quando si è pronti premere il tasto "Start" per iniziare il test, Il pulsante una volta premuto s'illuminerà di colore viola.  
- Selezionare la risposta che s'intende dare tramite il pulsante a sinistra del riquadro della risposta stessa, una volta premuto il pulsante su di esso apparirà una "X" per segnare la risposta data, si colorerà di verde (risposta giusta) e di rosso (risposta sbagliata) a seconda della correttezza della risposta data.  
- Tramite i pulsanti di navigazione ("Domanda precedente" e "Domanda Successiva") e possibile cambiare domanda. (N.B. è possibile tramite questi tasti saltare le domande a cui si vuole rispondere in un secondo momento).  
- In qualsiasi momento è possibile premere il pulsante "Stop" per ripristinare lo stato iniziale del programma e svolgere quindi un'altra prova. - I risultati della prova si possono vedere sempre tramite i riquadri "Domande giuste" e "Domande sbagliate".  

### Come esercitarsi sulle singole domande

Una volta aver avviato la finestra "Domande patente nautica".  
Nel livello superiore è presente il pulsante "Cerca Domanda" con affianco un riquadro dove poter scrivere il numero della domanda da cercare.  
Il programma (oltre alla possibilità di simulare delle prove d'esame) consente di poter ricercare (se segnate) le domande sbagliate durante le simulazione, in modo da potersi esercitare nuovamente su di esse.  
Il procedimento consiste in:  
- Selezionare la categoria di domande sulla quale si vuole fare la ricerca (entro/oltre 12 miglia).  
- Digitare nel riquadro "Cerca domanda" il numero della domanda che si vuole cercare.  
- Premere il pulsante "Cerca Domanda".  
Se si fanno più ricerche, tutte le domande cercate saranno messe in coda (anche quelle a cui si è già riposto); la coda è navigabile tramite i pulsanti di scorrimento "Domanda Precedente" e "Domanda Successiva".  

### Come esercitarsi sulle domande secondo i capitoli  

Una volta aver avviato la finestra "Esercitazione quiz d'esame".  
- Cliccando e scorrendo il menù a tendina è possibile selezionare il capitolo contenente le domande sulle quali ci si vuole esercitare. Una volta selezionato il capitolo, la selezione apparirà nel riquadro "Capitolo scelto" - Premendo il tasto "Start" si inizia la prova e il pulsante s'illumina di colore viola.  
- Selezionare la risposta che s'intende dare tramite il pulsante a sinistra del riquadro della risposta stessa, una volta premuto il pulsante su di esso apparirà una "X" per segnare la risposta data, si colorerà di verde (risposta giusta) e di rosso (risposta sbagliata) a seconda della correttezza della risposta data.  
- Tramite i pulsanti di navigazione ("Domanda precedente" e "Domanda Successiva") è possibile cambiare domanda. (N.B. è possibile tramite questi tasti saltare le domande a cui si vuole rispondere in un secondo momento).  
- In qualsiasi momento è possibile premere il pulsante "Stop" per ripristinare lo stato iniziale del programma e svolgere quindi un'altra prova. - I risultati della prova si possono vedere sempre tramite i riquadri "Domande giuste" e "Domande sbagliate".  

### Come modificare i quiz del programma

Dopo aver premuto il pulsante "Modifica i quiz" sul pannello principale.  
- Per modificare i quiz è necessario inserire una password per poter avviare l'editor, tale password è modificabile premendo il pulsante "Modifica password" che a patto che si inserisca l'ultima password valida, permette di salvare una nuova password.  
- Una volta aver scritto l'ultima password valida nel apposito riquadro e aver premuto il pulsante "Apri l'editor dei quiz", se la password è corretta si aprirà "L'editor dei quiz".  
- Selezionare la categoria di domande che si vuole modificare/aggiungere.  
- Una volta caricato il database con le domande, scorrere tra le domande con i tasti di scorrimento ("Domanda precedente" e "Domanda successiva") per raggiungere la domanda che s'intende modificare (nel caso in cui si vuole aggiungere una domanda ad un indice non precedentemente occupato da una domanda, esso è raggiungibile solo con i tasti di scorrimento) oppure digitare nel riquadro a destra del pulsante "Cerca domanda" l'indice della domanda che si vuole raggiungere, per poi premere il pulsante "Cerca Domanda".  
- Una volta raggiunto l'indice desiderato verificare se una domanda lo occupa, guardando "stato del quiz", se è di colore verde vuol dire che è presente una domanda in quella posizione (se presente la domanda viene mostrata negli appositi riquadri), se è di colore rosso vuol dire che l'indice è libero e che quindi la domanda che si andrà a scrivere occuperà quella posizione precedentemente libera.
- Per aggiungere una immagine basta trascinare l'immagine che si desidera inserire nel riquadro di colore nero. Per eliminare una immagine inserita basta premere il pulsante "Cancella immagine".  
- Una volta terminate le modifiche, oppure dopo avere inserito una nuovo quiz, premere il pulsante "Inserisci/Salva quiz" per salvare il lavoro fatto all'interno del database. - Per rendere le modifiche permanenti è sufficiente premere il pulsante "Salva database", in questo modo verrà scritto/aggiornato un file all'interno della cartella nella quale è presente il programma.  

## ⚠️ Avvisi


### Informazioni riguardo i file del programma

Nel programma sono presenti tre tipi di database: le domande "Entro 12 miglia", "Oltre 12 miglia" e un piccolo database che contiene delle domande di prova.
Questi tre database sono salvati localmente nel computer tramite 3 file ".txt" e rispettivamente sono "Within 12 miles" per le domande entro le 12 miglia, "beyond 12 miles" per le domande oltre le 12 miglia e per finire "Test" che contiene delle domande di prova. Se alla occorrenza uno dei due principali database non è presente il programma caricherà una nuova istanza dello stesso, che verrà poi scritta salvata fisicamente dopo aver premuto il pulsante "Salva Database".  
Se un database non possiede sufficienti domande per avviare una prova di simulazione, al posto del corrispettivo verrà caricato il database di Test, in modo che comunque si possa provare il programma.  
Qualora il file di test non sia presente il programma lancia un errore e non carica niente.  
