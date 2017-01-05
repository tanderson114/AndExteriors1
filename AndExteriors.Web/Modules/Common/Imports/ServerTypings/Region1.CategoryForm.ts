namespace AndExteriors.Region1 {
    export class CategoryForm extends Serenity.PrefixedContext {
        static formKey = 'Region1.Category';

    }

    export interface CategoryForm {
        CategoryName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    [['CategoryName', () => Serenity.StringEditor], ['Description', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(CategoryForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

