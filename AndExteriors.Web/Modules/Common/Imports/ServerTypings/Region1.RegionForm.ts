namespace AndExteriors.Region1 {
    export class RegionForm extends Serenity.PrefixedContext {
        static formKey = 'Region1.Region';

    }

    export interface RegionForm {
        RegionID: Serenity.IntegerEditor;
        RegionDescription: Serenity.StringEditor;
    }

    [['RegionID', () => Serenity.IntegerEditor], ['RegionDescription', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(RegionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

