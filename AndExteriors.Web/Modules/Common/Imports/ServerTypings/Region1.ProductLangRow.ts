namespace AndExteriors.Region1 {
    export interface ProductLangRow {
        Id?: number;
        ProductId?: number;
        LanguageId?: number;
        ProductName?: string;
    }

    export namespace ProductLangRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ProductName';
        export const localTextPrefix = 'Region1.ProductLang';

        export namespace Fields {
            export declare const Id: string;
            export declare const ProductId: string;
            export declare const LanguageId: string;
            export declare const ProductName: string;
        }

        ['Id', 'ProductId', 'LanguageId', 'ProductName'].forEach(x => (<any>Fields)[x] = x);
    }
}

