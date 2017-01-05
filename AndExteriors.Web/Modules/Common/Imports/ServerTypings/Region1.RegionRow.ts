namespace AndExteriors.Region1 {
    export interface RegionRow {
        RegionID?: number;
        RegionDescription?: string;
    }

    export namespace RegionRow {
        export const idProperty = 'RegionID';
        export const nameProperty = 'RegionDescription';
        export const localTextPrefix = 'Region1.Region';
        export const lookupKey = 'Region1.Region';

        export function getLookup(): Q.Lookup<RegionRow> {
            return Q.getLookup<RegionRow>('Region1.Region');
        }

        export namespace Fields {
            export declare const RegionID: string;
            export declare const RegionDescription: string;
        }

        ['RegionID', 'RegionDescription'].forEach(x => (<any>Fields)[x] = x);
    }
}

