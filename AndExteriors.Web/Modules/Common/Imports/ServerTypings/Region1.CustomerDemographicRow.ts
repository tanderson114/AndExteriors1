namespace AndExteriors.Region1 {
    export interface CustomerDemographicRow {
        ID?: number;
        CustomerTypeID?: string;
        CustomerDesc?: string;
    }

    export namespace CustomerDemographicRow {
        export const idProperty = 'ID';
        export const nameProperty = 'CustomerTypeID';
        export const localTextPrefix = 'Region1.CustomerDemographic';

        export namespace Fields {
            export declare const ID: string;
            export declare const CustomerTypeID: string;
            export declare const CustomerDesc: string;
        }

        ['ID', 'CustomerTypeID', 'CustomerDesc'].forEach(x => (<any>Fields)[x] = x);
    }
}

