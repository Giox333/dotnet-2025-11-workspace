//Es:1
const somma = (n1: number, n2: number): number => n1 + n2

//Es:2
const moltiplica = (n1: number, n2: number): number => n1 * n2

//Es:3
const stringaInizio = (str: string): string => str[0]

//Es:4
const stringaFinale = (str: string): string => str[str.length-1]

//Es:5
const maiuscolo = (str: string): string => str.toUpperCase()

//Es:6
const pari = (n: number): boolean => n%2 == 0 ? true : false

//Es:7
const vuota = (str: string): boolean => str.length === 0

//Es:8
const saluto = (str: string) => vuota(str) ? "Ciao" : "Ciao " + str

//Es:9
const defaultParametro = (n1: number, n2: number = 5): number => n1 + n2

//Es:10
const restParameters  = (...n: number[]): number =>{
    let somma: number = 0
    for(let numero of n)
        somma = numero + somma
    return somma
}

//Es:11
const raddoppia = (a: number[]) =>{
    /* let mappa: Map<number,number> = new Map()
    for(let i : number = 0; i < a.length; i++){
        mappa.set(a[i],a[i]*2)
    }
    return mappa */
    return a.map(numero => numero*2)
}

//Es:12
const filtrarePari = (...n: number[]) => n.filter((numero) => numero%2 == 0)

//Es:13
const sommaReduce = (n: number[]): number  => n.reduce((accumulatore, valoreAttuale) => accumulatore + valoreAttuale, 0,)

//Es:14
const mappaLunghezze = (str: string[]) =>{
    /* let mappa: Map<string,number> = new Map()
    for(let i : number = 0; i < str.length; i++){
        mappa.set(str[i],str[i].length)
    }
    return mappa */
    return str.map(stringa => stringa.length)
}

//Es:15
const filtraCorte = (str: string[]): string[] => str.filter((stringa) => stringa.length > 3) 

//Es:16
const ordinaArray = (arr: number[])  => arr.sort((a,b) => a - b)

//Es:17
const ordinaString = (str: string[])  => str.sort()

//Es:18
//Usare find con arrow function per trovare il primo numero maggiore di 10.
const trovaNumero = (arr: number[]) => arr.find((numero) => numero >10)

//Es:19
//Appiattire un array di array: [[1], [2], [3]] → [1,2,3]
const flattenArray = (arr: any) => arr.flat()

//Es:20
//Filtrare un array eliminando null e undefined.
const eliminaNull = (arr: any ) => arr.filter((elemento: any) => (elemento != null) || (elemento != undefined))

//Es:21
//Arrow function che restituisce un oggetto { id: number, nome: string }.
type oggetto = { id: number, nome: string }
const costruisciOggetto = (identificativo: number, name: string) => {
    const obj : oggetto = {id: identificativo, nome: name}
    return obj
}

//Es:22
//Arrow function che accetta { nome, cognome } e restituisce "nome cognome".
const 

//Test
console.log("***********************************************************************************************")
let a : number[] = [1,4,8,3,8,29]
let stringhe: string[] = ["aa","ciao","Gianluca","aisydtfvyaadfva","ab"]

/* console.log(somma(1,5))
console.log(moltiplica(1,5))
console.log(stringaInizio("ciao"))
console.log(stringaFinale("ciao"))
console.log(maiuscolo("ciao"))
console.log(pari(4))
console.log(vuota(null))
console.log(saluto("Gianni")) 
console.log(defaultParametro(10))
let a : number[] = [1,4,76,3,8,29]
console.log(raddoppia(a))
console.log(restParameters(1,4,76,3,8,29)) 
console.log(filtrarePari(1,4,76,3,8,29))
let a : number[] = [1,4,76,3,8,29]
console.log(sommaReduce(a))

let stringhe: string[] = ["aa","ciao","Gianluca","aisydtfvyaadfva"]
console.log(mappaLunghezze(stringhe))

let a : number[] = [1,4,76,3,8,29]
console.log(raddoppia(a))

let a : number[] = [1,2,3,4,5,6]
console.log(sommaReduce(a))

let stringhe: string[] = ["aa","ciao","Gianluca","aisydtfvyaadfva"]
console.log(mappaLunghezze(stringhe))

let stringhe: string[] = ["aa","ciao","Gianluca","aisydtfvyaadfva","ab"]
console.log(filtraCorte(stringhe))

let a : number[] = [1,4,76,3,8,29]
let stringhe: string[] = ["aa","ciao","Gianluca","aisydtfvyaadfva","ab"]
console.log(ordinaArray(a))
console.log(ordinaString(stringhe))

console.log(trovaNumero(a))

let arr2 = [[1],[2],[3,4]]
console.log(flattenArray(arr2))

let arr = [1,"asd",null, 56, 90, undefined, "bb", "ciao"]

console.log(eliminaNull(arr))*/

console.log(costruisciOggetto(1,"Giovanni"))
