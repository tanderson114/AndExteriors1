namespace AndExteriors.Region1 {
    export interface ShipperRow {
        ShipperID?: number;
        CompanyName?: string;
        Phone?: string;
    }

    export namespace ShipperRow {
        export const idProperty = 'ShipperID';
        export const nameProperty = 'CompanyName';
        export const localTextPrefix = 'Region1.Shipper';
        export const lookupKey = 'Region1.Shipper';

        export function getLookup(): Q.Lookup<ShipperRow> {
            return Q.getLookup<ShipperRow>('Region1.Shipper');
        }

        export namespace Fields {
            export declare const ShipperID: string;
            export declare const CompanyName: string;
            export declare const Phone: string;
        }

        ['ShipperID', 'CompanyName', 'Phone'].forEach(x => (<any>Fields)[x] = x);
    }
}

