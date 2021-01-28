<?php

namespace App\Http\Controllers;

use App\Company;
use Illuminate\Http\Request;

class CompanyController extends Controller
{

    public function index()
    {
        return Company::with('user')->get();
    }

    public function create()
    {
        //
    }

    public function store(Request $request)
    {
        $this->validate($request,[
            'user_id'           =>  'required',
            'company_name'      =>  'required',
            'company_phone'     =>  'required',
            'company_address'   =>  'required'
        ],
            [
                'user_id.required'          =>  'Kullanıcı Seçiniz!',
                'company_name.required'     =>  'Şirket Ünvanı Giriniz!',
                'company_phone.required'    =>  'Şirket Telefonu Giriniz!',
                'company_address.required'  =>  'Şirket Adresi Giriniz!',
            ]);
        Company::create($request->all());
        return response('Şirket Bilgileri Başarıyla Kayıt Edildi!',200);
    }

    public function show($id)
    {
        return Company::where('id','=',$id)->with('user')->get();
    }

    public function edit($id)
    {
        //
    }

    public function update(Request $request, $id)
    {
        $this->validate($request,[
            'user_id'           =>  'required',
            'company_name'      =>  'required',
            'company_phone'     =>  'required',
            'company_address'   =>  'required'
        ],
            [
                'user_id.required'          =>  'Kullanıcı Seçiniz!',
                'company_name.required'     =>  'Şirket Ünvanı Giriniz!',
                'company_phone.required'    =>  'Şirket Telefonu Giriniz!',
                'company_address.required'  =>  'Şirket Adresi Giriniz!',
            ]);
        Company::find($id)->update($request->all());
    }

    public function destroy($id)
    {
        Company::destroy($id);
    }
}
