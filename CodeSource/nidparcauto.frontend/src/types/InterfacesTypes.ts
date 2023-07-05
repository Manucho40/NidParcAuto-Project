export interface CommunesInterface{
    id: number,
    libelle: string,
    iduser?: number,
    dateCreation?: Date,
    modifieLe?: Date,
    modifiePar?: null,
    stateCode?: number,
    statusCode?: number
}
export interface EnergiesInterface{
    idEnergie: number,
    libEnergie: string,
    iduser?: number,
    dateCreation?: string,
    modifieLe?: string,
    modifiePar?: null,
    stateCode?: number,
    statusCode?: number
}