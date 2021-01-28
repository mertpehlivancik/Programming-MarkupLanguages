<?php

namespace App\Http\Controllers;

use App\Outgoing;
use Illuminate\Http\Request;

class OutgoingController extends Controller
{

    public function index()
    {
        return Outgoing::with('company','company.user')->get();
    }


    public function create()
    {
    }


    public function store(Request $request)
    {
        $this->validate($request,[
            'company_id'        =>  'required',
            'amount'            =>  'required',
        ],
            [
                'company_id.required' =>  'Şirket Seçiniz!',
                'amount.required'     =>  'Gelen Tutar Giriniz!',
            ]);
        Outgoing::create($request->all());
        return response('Kayıt Başarıyla Eklendi!',200);
    }

    public function show($id)
    {
        return Outgoing::where('id','=',$id)->with('company','company.user')->get();
    }

    public function edit($id)
    {

    }

    public function update(Request $request, $id)
    {
        $this->validate($request,[
            'company_id'        =>  'required',
            'amount'            =>  'required',
        ],
            [
                'company_id.required' =>  'Şirket Seçiniz!',
                'amount.required'     =>  'Gelen Tutar Giriniz!',
            ]);
        Outgoing::find($id)->update($request->all());
        return response('Kayıt Başarıyla Düzenlendi!',200);
    }

    public function destroy($id)
    {
        Outgoing::destroy($id);
        return response('Kayıt Başarıyla Silindi!',200);
    }
}
