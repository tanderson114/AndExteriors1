namespace AndExteriors.Region1 {
    export interface CategoryRow {
        CategoryID?: number;
        CategoryName?: string;
        Description?: string;
        Picture?: number[];
    }

    export namespace CategoryRow {
        export const idProperty = 'CategoryID';
        export const nameProperty = 'CategoryName';
        export const localTextPrefix = 'Region1.Category';
        export const lookupKey = 'Region1.Category';

        export function getLookup(): Q.Lookup<CategoryRow> {
            return Q.getLookup<CategoryRow>('Region1.Category');
        }

        export namespace Fields {
            export declare const CategoryID: string;
            export declare const CategoryName: string;
            export declare const Description: string;
            export declare const Picture: string;
        }

        ['CategoryID', 'CategoryName', 'Description', 'Picture'].forEach(x => (<any>Fields)[x] = x);
    }
}

