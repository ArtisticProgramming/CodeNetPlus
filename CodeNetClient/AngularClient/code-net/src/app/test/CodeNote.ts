export interface CodeNote {
    id: number;
    title:string;
    description:string;
    projectId:number;
    noteTypeId:number;
    generalSubjectId:number;
    specificSubjectId: number;
    isBookMarked: boolean;
    createdDate: string;
    modifiedDate:string;
}
